using System;

namespace TestDeviceDriver
{
    [Serializable]
    public class DevicePara : ServerSuperIO.Device.DeviceParameter
    {
        public override object Repair()
        {
            return new DevicePara();
        }
    }
}