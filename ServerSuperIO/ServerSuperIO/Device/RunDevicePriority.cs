using ServerSuperIO.Common;

namespace ServerSuperIO.Device
{
    public enum DevicePriority
    {
        [EnumDescription("��ͨ")]
        Normal = 0x00,

        [EnumDescription("����")]
        Priority = 0x01
    }
}