using ServerSuperIO.Config;
using ServerSuperIO.Device;
using ServerSuperIO.Log;
using System.Collections;

namespace ServerSuperIO.Server
{
    public interface IServerManager : IEnumerable
    {
        IServer this[int index] { get; }

        IServer CreateServer(IServerConfig config, IDeviceContainer deviceContainer = null, ILogContainer logContainer = null);

        void AddServer(IServer server);

        IServer GetServer(string serverName);

        bool ContainsServer(string serverName);

        IServer[] GetServers();

        void RemoveServer(string serverName);

        void RemoveAllServer();

        int Count { get; }
    }
}