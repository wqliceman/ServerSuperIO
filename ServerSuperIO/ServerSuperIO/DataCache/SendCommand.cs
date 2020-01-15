using System;

namespace ServerSuperIO.DataCache
{
    public class SendCommand : ServerSuperIO.DataCache.ISendCommand
    {
        private byte[] _Bytes = new byte[] { };

        /// <summary>
        /// ����
        /// </summary>
        public byte[] Bytes
        {
            get { return _Bytes; }
        }

        private string _Key = String.Empty;

        /// <summary>
        /// ��������
        /// </summary>
        public string Key
        {
            get { return _Key; }
        }

        private Priority _Priority = Priority.Normal;

        /// <summary>
        /// �������ȼ�����ʱ����
        /// </summary>
        public Priority Priority
        {
            get { return _Priority; }
        }

        /// <summary>
        /// �豸����
        /// </summary>
        /// <param name="cmdkeys">��������</param>
        /// <param name="cmdbytes">�����ֽ�����</param>
        public SendCommand(string cmdkey, byte[] cmdbytes)
        {
            this._Key = cmdkey;
            this._Bytes = cmdbytes;
            this._Priority = Priority.Normal;
        }

        /// <summary>
        /// �豸����
        /// </summary>
        /// <param name="cmdkeys">��������</param>
        /// <param name="cmdbytes">�����ֽ�����</param>
        public SendCommand(string cmdkey, byte[] cmdbytes, Priority priority)
        {
            this._Key = cmdkey;
            this._Bytes = cmdbytes;
            this._Priority = priority;
        }
    }
}