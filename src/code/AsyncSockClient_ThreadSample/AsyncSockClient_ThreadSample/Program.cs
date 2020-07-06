using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using _000_Common;
using CommunicationManager;
using LogMgr;

namespace AsyncSockClient_ThreadSample
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            AsyncServerTest();
        }

        public void AsyncServerTest()
        {
            for (int i = 0; i < 1; ++i)
            {
                Thread LogThrd = new Thread(SocketTest) {IsBackground = true};
                LogThrd.Name = string.Format("{0}Thrd", i.ToString());
                LogThrd.IsBackground = true;
                LogThrd.Start();
            }

            while (true)
            {
                Thread.Sleep(1000);
            }
        }

        private void SocketTest(object param)
        {
            string strName = Thread.CurrentThread.Name;

            LogConfig config = new LogConfig("Client", @"D:\Log\");
            config.ArrDirectoryDapth.Add(strName);
            config.Level = LOG_LEVEL.LL_DEBUGGING;

            SocketClient client = new SocketClient(config, new ReceiveCallback(Receive));
            ST_CLIENT_INIT init = new ST_CLIENT_INIT("192.168.0.103", 10004);

            try
            {
                //103
                //175

                Random rand = new Random();
                int sleep = rand.Next(100, 1000);
                bool bLoop = true, bLoop2 = true;
                while (bLoop)
                {
                    if (ERROR_CODE.EC_SUCCESS == client.Connect(init) || ERROR_CODE.EC_ALREADY_CONNECTED == client.Connect(init))
                    {
                        bLoop2 = true;
                        while (bLoop2)
                        {
                            string msg = "";
                            for (char letter = 'A'; letter <= 'Z'; letter++)
                            {
                                msg = String.Format($"[{strName}] {letter.ToString()}");

                                byte[] byteData = Encoding.Default.GetBytes(msg);
                                if (ERROR_CODE.EC_SUCCESS != client.Send(msg))
                                {
                                    bLoop2 = false;
                                    break;
                                }

                                Thread.Sleep(sleep);
                            }
                            bLoop2 = false;

                            Thread.Sleep(1000);
                        }

                        client.Disconnect();
                    }
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            Console.WriteLine("클라이언트를 종료합니다.");
        }

        public void Receive(string message)
        {
            Console.WriteLine($"Receive : {message}");
        }
    }
}
