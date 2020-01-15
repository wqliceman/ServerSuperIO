namespace ServerSuperIO.Config
{
    public interface IServerConfigProvider
    {
        IServerConfig ServerConfig { get; }
    }
}