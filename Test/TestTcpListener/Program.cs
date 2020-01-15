using ServerSuperIO.Communicate;
using ServerSuperIO.Communicate.NET;
using ServerSuperIO.Config;
using ServerSuperIO.Server;
using System;

namespace TestTcpListener
{
    internal class Program
    {
        private static IServer _server;
        private static int _Counter = 0;

        private static void Main(string[] args)
        {
            _server = new ServerManager().CreateServer(new ServerConfig()
            {
                ServerName = "myserver",
                SocketMode = SocketMode.Udp,
                ControlMode = ControlMode.Parallel,
                CheckSameSocketSession = false,
            });
            _server.SocketConnected += server_SocketConnected;
            _server.SocketClosed += server_SocketClosed;
            _server.Start();

            while (true)
            {
                string str = Console.ReadLine();

                if (str == "stop")
                {
                    _server.Stop();
                    break;
                }
            }

            Console.Read();
        }

        private static void server_SocketClosed(string ip, int port)
        {
            lock (_server)
            {
                _Counter--;
                Console.WriteLine(String.Format("{0},连接：{1}-{2} 断开", _Counter, ip, port));
            }
        }

        private static void server_SocketConnected(string ip, int port)
        {
            lock (_server)
            {
                _Counter++;
                Console.WriteLine(String.Format("{0},连接：{1}-{2} 成功", _Counter, ip, port));
            }
        }
    }
}