using ServerSuperIO.Communicate;
using ServerSuperIO.Persistence;

namespace ServerSuperIO.Device
{
    public interface IDeviceDynamic : IXmlPersistence
    {
        /// <summary>
        /// �豸ID
        /// </summary>
        string DeviceID { get; set; }

        /// <summary>
        /// ��ǰ��ע˵��
        /// </summary>
        string Remark { get; set; }

        /// <summary>
        /// �豸����״̬
        /// </summary>
        RunState RunState { get; set; }

        /// <summary>
        /// �豸��ͨѶ״̬
        /// </summary>
        CommunicateState CommunicateState { get; set; }

        /// <summary>
        /// IO״̬
        /// </summary>
        ChannelState ChannelState { get; set; }

        /// <summary>
        /// ��ñ���״̬����
        /// </summary>
        /// <returns></returns>
        string GetAlertState();
    }
}