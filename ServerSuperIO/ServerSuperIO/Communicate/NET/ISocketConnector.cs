using ServerSuperIO.Server;
using System;

namespace ServerSuperIO.Communicate.NET
{
    internal interface ISocketConnector : IServerProvider, IDisposable
    {
        void Start();

        void Stop();

        event NewClientAcceptHandler NewClientConnected;

        event ErrorHandler Error;
    }
}