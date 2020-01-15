using ServerSuperIO.DataCache;

namespace ServerSuperIO.Communicate.NET
{
    public interface ISocketAsyncEventArgsEx : IReceiveCache
    {
        /// <summary>
        /// 初始化
        /// </summary>
        void Initialize();
    }
}