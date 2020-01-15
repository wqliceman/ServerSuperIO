﻿using System;

namespace ServerSuperIO.Device.Connector
{
    public delegate void DeviceConnectorHandler(object source, DeviceConnectorArgs args);

    public class DeviceConnectorArgs : EventArgs
    {
        public DeviceConnectorArgs(IFromDevice fromDevice, IDeviceToDevice toDevice)
        {
            FromDevice = fromDevice;
            DeviceToDevice = toDevice;
        }

        public IFromDevice FromDevice { get; private set; }

        public IDeviceToDevice DeviceToDevice { get; private set; }
    }
}