namespace ServerSuperIO.Log
{
    public interface ILoggerProvider
    {
        ILog Logger { get; }
    }
}