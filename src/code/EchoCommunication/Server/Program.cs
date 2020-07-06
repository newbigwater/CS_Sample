using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            string localIP = "192.168.0.31";

            const int bindPort = 5425;
            TcpListener server = null;

            try
            {
                IPEndPoint localAddr = new IPEndPoint(IPAddress.Parse(localIP), bindPort);
                server = new TcpListener(localAddr);
                server.Start();

                Console.WriteLine("Echo Server Start...");

                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine($"Client Accep : {((IPEndPoint) client.Client.RemoteEndPoint).ToString()}");

                    NetworkStream stream = client.GetStream();

                    int length;
                    string data = null;
                    byte[] bytes = new byte[256];

                    while ((length = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        data = Encoding.Default.GetString(bytes, 0, length);
                        Console.WriteLine($"Recive : {data}");

                        byte[] msg = Encoding.Default.GetBytes(data);
                        stream.Write(msg, 0, msg.Length);
                        Console.WriteLine($"Sand : {data}");
                    }

                    stream.Close();
                    client.Close();
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
            finally
            {
                server.Stop();
            }

            Console.WriteLine("서버를 종료합니다.");
        }
    }
}
