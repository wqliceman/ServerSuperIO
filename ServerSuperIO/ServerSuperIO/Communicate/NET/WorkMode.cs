using ServerSuperIO.Common;

namespace ServerSuperIO.Communicate.NET
{
    public enum WorkMode
    {
        [EnumDescription("�����ģʽ")]
        TcpServer = 0x00,

        [EnumDescription("�ͻ���ģʽ")]
        TcpClient = 0x01
    }
}