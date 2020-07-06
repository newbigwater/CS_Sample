using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        private void SocketTest(object param)
        {
            string strName = Thread.CurrentThread.Name;
            Logger log = new Logger(strName);
            while (true)
            {
                log.Debug("Debug : AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
                log.Info("Info : AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
                log.Warn("Warn : AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
                log.Error("Error : AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
                log.Fatal("Fatal : AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");

                Thread.Sleep(1);
            }
        }

        static void Main(string[] args)
        {
            string localIP = "192.168.0.31";
            string serverIP = localIP;
            const int serverPort = 5425;

            try
            {
                IPEndPoint localAddress = new IPEndPoint(IPAddress.Parse(localIP), 0);
                IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse(serverIP), serverPort);

                Console.WriteLine($"Client : {localAddress.ToString()}, Server : {serverAddress.ToString()}");

                TcpClient client = new TcpClient(localAddress);
                client.Connect(serverAddress);

                NetworkStream stream = client.GetStream();

                bool bLoop = true;
                while (bLoop)
                {
                    Console.Write("MSG : ");
                    string msg = Console.ReadLine();
                    if (msg.Equals("EXIT"))
                    {
                        bLoop = false;
                        return;
                    }


                    byte[] data = System.Text.Encoding.Default.GetBytes(msg);
                    stream.Write(data, 0, data.Length);
                    Console.WriteLine($"Sand : {msg}");

                    data.Initialize();
                    int bytes = stream.Read(data, 0, data.Length);

                    string responseData = Encoding.Default.GetString(data, 0, bytes);
                    Console.WriteLine($"Recive : {responseData}");
                }

                stream.Close();
                client.Close();
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
    }
}
