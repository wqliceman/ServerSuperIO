using System;

namespace ServerSuperIO.Device
{
    public class BaseArgs : System.EventArgs
    {
        private string _DeviceID = String.Empty;
        private string _DeviceCode = String.Empty;
        private int _DeviceAddr = -1;
        private string _DeviceName = String.Empty;

        public BaseArgs(string devid, string devCode, int devaddr, string devname)
        {
            this._DeviceAddr = devaddr;
            this._DeviceCode = devCode;
            this._DeviceID = devid;
            this._DeviceName = devname;
        }

        public string DeviceID
        {
            get { return this._DeviceID; }
        }

        public string DeviceCode
        {
            get { return this._DeviceCode; }
        }

        public int DeviceAddr
        {
            get { return this._DeviceAddr; }
        }

        public string DeviceName
        {
            get { return this._DeviceName; }
        }
    }

    public class ComParameterExchangeArgs : BaseArgs
    {
        private int _oldcom = 1;
        private int _oldbaud = 9600;
        private int _newcom = 1;
        private int _newbaud = 9600;

        public ComParameterExchangeArgs(string devid, string devCode, int devaddr, string devname, int port, int baud, int oldcom, int oldbaud, int newcom, int newbaud)
            : base(devid, devCode, devaddr, devname)
        {
            this._oldcom = oldcom;
            this._oldbaud = oldbaud;
            this._newcom = newcom;
            this._newbaud = newbaud;
        }

        public int OldCOM
        {
            get { return this._oldcom; }
        }

        public int NewCOM
        {
            get { return this._newcom; }
        }

        public int OldBaud
        {
            get { return this._oldbaud; }
        }

        public int NewBaud
        {
            get { return this._newbaud; }
        }
    }

    /// <summary>
    /// ͨѶ��Ϣ�¼�����
    /// </summary>
    public class CommunicationArgs : BaseArgs
    {
        private object _io1 = new object();  //�п�����IP���п�����COM
        private object _io2 = new object();  //�п�����PORT,�п����ǲ�����

        public CommunicationArgs(string devid, string devCode, int devaddr, string devname, object ioparameter1, object ioparameter2)
            : base(devid, devCode, devaddr, devname)
        {
            this._io1 = ioparameter1;
            this._io2 = ioparameter2;
        }

        public object IOParameter1
        {
            get { return this._io1; }
        }

        public object IOParameter2
        {
            get { return this._io2; }
        }
    }

    /// <summary>
    /// ���������¼�����
    /// </summary>
    //public class ReceiveDataArgs : CommunicationArgs
    //{
    //    private byte[] _Data = new byte[] { };

    //    public ReceiveDataArgs(int devid, int devaddr, string devname, object io1, object io2, byte[] data)
    //        : base(devid, devaddr, devname, io1, io2)
    //    {
    //        this._Data = data;
    //    }

    //    public byte[] Data
    //    {
    //        get { return this._Data; }
    //    }
    //}

    /// <summary>
    /// ���������¼�����
    /// </summary>
    public class SendDataArgs : CommunicationArgs
    {
        private byte[] _Data = new byte[] { };

        public SendDataArgs(string devid, string devCode, int devaddr, string devname, object io1, object io2, byte[] data)
            : base(devid, devCode, devaddr, devname, io1, io2)
        {
            this._Data = data;
        }

        public byte[] Data
        {
            get { return this._Data; }
        }
    }

    /// <summary>
    /// ������־�¼�����
    /// </summary>
    public class DeviceRuningLogArgs : BaseArgs
    {
        private string _StateDesc = String.Empty;

        public DeviceRuningLogArgs(string devid, string devCode, int devaddr, string devname, string statedesc)
            : base(devid, devCode, devaddr, devname)
        {
            this._StateDesc = statedesc;
        }

        public string StateDesc
        {
            get { return this._StateDesc; }
        }
    }

    /// <summary>
    /// ��ʾ�����¼�����
    /// </summary>
    public class DeviceObjectChangedArgs : BaseArgs
    {
        private object _Object = null;
        private DeviceType _DeviceType = DeviceType.Common;

        public DeviceObjectChangedArgs(string devid, string devCode, int devaddr, string devname, object obj, DeviceType devtype)
            : base(devid, devCode, devaddr, devname)
        {
            _Object = obj;
            _DeviceType = devtype;
        }

        public object Object
        {
            get { return _Object; }
        }

        public DeviceType DeviceType
        {
            get { return _DeviceType; }
            set { _DeviceType = value; }
        }
    }

    /// <summary>
    /// ɾ���豸�¼�����
    /// </summary>
    public class DeleteDeviceArgs : BaseArgs
    {
        public DeleteDeviceArgs(string devid, string devCode, int devaddr, string devname)
            : base(devid, devCode, devaddr, devname)
        {
        }
    }

    /// <summary>
    /// �����������¼�����
    /// </summary>
    public class UpdateContainerArgs : BaseArgs
    {
        private object _Object;

        public UpdateContainerArgs(string devid, string devCode, int devaddr, string devname, object obj)
            : base(devid, devCode, devaddr, devname)
        {
            _Object = obj;
        }

        public object Object
        {
            get
            {
                return _Object;
            }
        }
    }
}