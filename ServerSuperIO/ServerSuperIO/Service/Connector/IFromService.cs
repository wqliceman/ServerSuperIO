﻿namespace ServerSuperIO.Service.Connector
{
    /// <summary>
    /// 来自传递的设备
    /// </summary>
    public interface IFromService
    {
        string ServiceName { get; }

        string ServiceKey { get; }
    }
}