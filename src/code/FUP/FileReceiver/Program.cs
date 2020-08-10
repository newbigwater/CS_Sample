using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using FUP;

namespace FileReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine($"사용법 : {Process.GetCurrentProcess().ProcessName} <Directory>");
                return;
            }

            uint msgID = 0;

            string dir = args[0];
            if (false == Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            const int bindPort = 5425;
            TcpListener server = null;
            try
            {
                IPEndPoint localAddress = new IPEndPoint(0, bindPort);

                server = new TcpListener(localAddress);
                server.Start();

                Console.WriteLine("파일 업로드 서버 시작...");
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine($"클라이언트 접속 : {((IPEndPoint) client.Client.RemoteEndPoint).ToString()}");

                    NetworkStream stream = client.GetStream();

                    Message reqMsg = MessageUtil.Receive(stream);
                    if (reqMsg.Header.MSGTYPE != CONSTANTS.REQ_FILE_SEND)
                    {
                        stream.Close();
                        client.Close();
                        continue;
                    }

                    BodyRequest reqBody = reqMsg.Body as BodyRequest;
                    Console.WriteLine("파일 업로드 요청이 왔습니다. 수락하시겠습니까? yes or no");
                    string answer = Console.ReadLine();

                    Message repMsg = new Message();
                    {
                        if (answer != "yes")
                        {
                            repMsg.Body = new BodyResponse()
                            {
                                MSGID = reqMsg.Header.MSGID,
                                RESPONSE = CONSTANTS.DENINED
                            };
                        }
                        else
                        {
                            repMsg.Body = new BodyResponse()
                            {
                                MSGID = reqMsg.Header.MSGID,
                                RESPONSE = CONSTANTS.ACCEPTED
                            };

                        }

                        repMsg.Header = new Header()
                        {
                            MSGID = msgID++,
                            MSGTYPE = CONSTANTS.REP_FILE_SEND,
                            BODYLEN = (uint) repMsg.Body.GetSize(),
                            FRAGMENTED = CONSTANTS.NOT_FRAGMENTED,
                            LASTMSG = CONSTANTS.NOT_LASMSG,
                            SEQ = 0
                        };
                        MessageUtil.Send(stream, repMsg);
                    }
                    if (answer != "yes")
                    {
                        stream.Close();
                        client.Close();
                        continue;
                    }

                    Console.WriteLine("파일 전송을 시작합니다...");

                    long fileSize = reqBody.FILESIZE;
                    string fileName = Encoding.Default.GetString(reqBody.FILENAME);
                    FileStream file = new FileStream($@"{dir}\{fileName}", FileMode.Create);

                    uint? dataMsgID = null;
                    ushort prevSeq = 0;
                    while (null != (reqMsg = MessageUtil.Receive(stream)))
                    {
                        Console.Write("#");
                        if (reqMsg.Header.MSGTYPE != CONSTANTS.FILE_SEND_DATA)
                            break;

                        if (null == dataMsgID)
                            dataMsgID = reqMsg.Header.MSGID;
                        else if (reqMsg.Header.MSGID != dataMsgID)
                            break;

                        if (reqMsg.Header.SEQ != prevSeq++)
                        {
                            Console.WriteLine($"{prevSeq}, {reqMsg.Header.SEQ}");
                            break;
                        }

                        file.Write(reqMsg.Body.GetBytes(), 0, reqMsg.Body.GetSize());

                        // 미분할 데이터 체크
                        if (CONSTANTS.NOT_FRAGMENTED == reqMsg.Header.FRAGMENTED)
                            break;

                        // 마지막 분할 데이터 체크
                        if (CONSTANTS.LASTMSG == reqMsg.Header.LASTMSG)
                            break;
                    }

                    long recvFileSize = file.Length;
                    file.Close();

                    Console.WriteLine();
                    Console.WriteLine($"수신 파일 크기 : {recvFileSize} bytes");

                    Message rstMsg = new Message();
                    {

                        if (recvFileSize == fileSize)
                        {
                            rstMsg.Body = new BodyResult()
                            {
                                MSGID = reqMsg.Header.MSGID,
                                RESULT = CONSTANTS.SUCCESS
                            };
                        }
                        else
                        {
                            rstMsg.Body = new BodyResult()
                            {
                                MSGID = reqMsg.Header.MSGID,
                                RESULT = CONSTANTS.FAIl
                            };
                        }

                        rstMsg.Header = new Header()
                        {
                            MSGID = msgID++,
                            MSGTYPE = CONSTANTS.FILE_SEND_RES,
                            BODYLEN = (uint) rstMsg.Body.GetSize(),
                            FRAGMENTED = CONSTANTS.NOT_FRAGMENTED,
                            LASTMSG = CONSTANTS.LASTMSG,
                            SEQ = 0
                        };
                        MessageUtil.Send(stream, rstMsg);
                    }

                    Console.WriteLine("파일 전송을 마쳤습니다.");
                    stream.Close();
                    client.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                server.Stop();
            }

            Console.WriteLine("서버를 종료합니다.");
            Console.ReadLine();
        }
    }
}
