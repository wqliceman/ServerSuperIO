﻿using ServerSuperIO.Device;
using System;
using System.IO;

namespace TestDeviceDriver
{
    /// <summary>
    /// 设备实时数据命令
    /// </summary>
    internal class DeviceFileCommand : ProtocolCommand
    {
        public override string Name
        {
            get { return CommandArray.FileData.ToString(); }
        }

        public override void ExcuteCommand<T>(T t)
        {
            throw new NotImplementedException();
        }

        public override void ExcuteCommand<T1, T2>(T1 t1, T2 t2)
        {
            throw new NotImplementedException();
        }

        public override byte[] Package<T>(string code, T t)
        {
            throw new NotImplementedException();
        }

        public override byte[] Package<T1, T2>(string code, T1 t1, T2 t2)
        {
            throw new NotImplementedException();
        }

        public override dynamic Analysis<T>(byte[] data, T t)
        {
            if (t != null)
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
                File.WriteAllBytes(path, t as byte[]);
                return path;
            }
            else
            {
                return null;
            }
        }

        public override dynamic Analysis<T1, T2>(byte[] data, T1 t1, T2 t2)
        {
            throw new NotImplementedException();
        }
    }
}