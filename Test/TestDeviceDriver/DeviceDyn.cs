﻿using ServerSuperIO.Device;
using System;

namespace TestDeviceDriver
{
    [Serializable]
    public class DeviceDyn : DeviceDynamic
    {
        public DeviceDyn() : base()
        {
            Dyn = new Dyn();
        }

        public override string GetAlertState()
        {
            throw new NotImplementedException("无报警信息");
        }

        public override object Repair()
        {
            return new DeviceDyn();
        }

        public Dyn Dyn { get; set; }
    }
}