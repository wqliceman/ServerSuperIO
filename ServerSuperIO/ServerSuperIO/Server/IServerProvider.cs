﻿namespace ServerSuperIO.Server
{
    public interface IServerProvider
    {
        /// <summary>
        /// 应用服务
        /// </summary>
        IServer Server { get; }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="appServer"></param>
        void Setup(IServer appServer);
    }
}