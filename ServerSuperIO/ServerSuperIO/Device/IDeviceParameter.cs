using ServerSuperIO.Communicate.COM;
using ServerSuperIO.Communicate.NET;
using ServerSuperIO.Persistence;

namespace ServerSuperIO.Device
{
    public interface IDeviceParameter : IVirtualDeviceParameter, IXmlPersistence
    {
        /// <summary>
        /// �豸ID������ϵͳ�Զ����ɵġ�
        /// </summary>
        string DeviceID { get; set; }

        /// <summary>
        /// �豸���룬�ֶ�������Ψһ
        /// </summary>
        string DeviceCode { get; set; }

        /// <summary>
        /// �豸��ַ���п������ظ�
        /// </summary>
        int DeviceAddr { get; set; }

        /// <summary>
        /// �豸����
        /// </summary>
        string DeviceName { get; set; }

        /// <summary>
        /// �Ƿ񱣴�ԭʼ����
        /// </summary>
        bool IsSaveOriginBytes { set; get; }

        /// <summary>
        /// �Ƿ񱨾�
        /// </summary>
        bool IsAlert { get; set; }

        /// <summary>
        /// ��������������ǲ�����ʾ����
        /// </summary>
        bool IsAlertSound { get; set; }

        /// <summary>
        /// ���ڲ�����Ϣ
        /// </summary>
        COMParameter COM { get; set; }

        /// <summary>
        /// �������ӵ�Զ�̲���
        /// </summary>
        SocketParameter NET { get; set; }

        /// <summary>
        /// ��ʽ������
        /// </summary>
        string DataFormat { get; set; }
    }
}