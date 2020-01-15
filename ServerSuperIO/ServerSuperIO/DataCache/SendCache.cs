using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ServerSuperIO.DataCache
{
    /// <summary>
    /// �̰߳�ȫ�������������ṩ�˴�һ�����һ��ֵ��ӳ�䡣
    /// </summary>
    /// <typeparam name="TKey">�ֵ��еļ�������</typeparam>
    /// <typeparam name="TValue">�ֵ��е�ֵ������</typeparam>
    public class SendCache : ServerSuperIO.DataCache.ISendCache
    {
        #region Fields

        /// <summary>
        /// �ڲ��� Dictionary ����
        /// </summary>
        private List<ISendCommand> _CmdCache = new List<ISendCommand>();

        /// <summary>
        /// ���ڲ���ͬ�����ʵ� RW ������
        /// </summary>
        private ReaderWriterLock _rwLock = new ReaderWriterLock();

        /// <summary>
        /// һ�� TimeSpan������ָ����ʱʱ�䡣
        /// </summary>
        private readonly TimeSpan _lockTimeOut = TimeSpan.FromMilliseconds(100);

        #endregion Fields

        #region Methods

        /// <summary>
        /// ��ָ���ļ���ֵ��ӵ��ֵ��С�
        /// Exceptions��
        ///     ArgumentException - Dictionary ���Ѵ��ھ�����ͬ����Ԫ�ء�
        /// </summary>
        /// <param name="key">Ҫ��ӵ�Ԫ�صļ���</param>
        /// <param name="value">��ӵ�Ԫ�ص�ֵ�������������ͣ���ֵ����Ϊ ������</param>
        public void Add(string cmdkey, byte[] cmdbytes)
        {
            this.Add(cmdkey, cmdbytes, Priority.Normal);
        }

        public void Add(string cmdkey, byte[] cmdbytes, Priority priority)
        {
            _rwLock.AcquireWriterLock(_lockTimeOut);
            try
            {
                SendCommand cmd = new SendCommand(cmdkey, cmdbytes, priority);
                this._CmdCache.Add(cmd);
            }
            finally { _rwLock.ReleaseWriterLock(); }
        }

        public void Add(ISendCommand cmd)
        {
            _rwLock.AcquireWriterLock(_lockTimeOut);
            try
            {
                if (cmd == null) return;

                this._CmdCache.Add(cmd);
            }
            finally { _rwLock.ReleaseWriterLock(); }
        }

        /// <summary>
        /// ɾ������
        /// </summary>
        /// <param name="cmdkey"></param>
        public void Remove(string cmdkey)
        {
            if (_CmdCache.Count <= 0)
            {
                return;
            }

            _rwLock.AcquireWriterLock(_lockTimeOut);
            try
            {
                ISendCommand cmd = this._CmdCache.FirstOrDefault(c => c.Key == cmdkey);
                if (cmd != null)
                {
                    this._CmdCache.Remove(cmd);
                }
            }
            finally { _rwLock.ReleaseWriterLock(); }
        }

        /// <summary>
        /// ���Ƴ����еļ���ֵ��
        /// </summary>
        public void Clear()
        {
            if (this._CmdCache.Count > 0)
            {
                _rwLock.AcquireWriterLock(_lockTimeOut);
                try
                {
                    this._CmdCache.Clear();
                }
                finally { _rwLock.ReleaseWriterLock(); }
            }
        }

        /// <summary>
        /// �����ȼ��������
        /// </summary>
        /// <param name="priority"></param>
        /// <returns></returns>
        public byte[] Get(Priority priority)
        {
            if (this._CmdCache.Count <= 0)
            {
                return new byte[] { };
            }

            _rwLock.AcquireReaderLock(_lockTimeOut);
            try
            {
                byte[] data = new byte[] { };
                if (priority == Priority.Normal)
                {
                    data = this._CmdCache[0].Bytes;
                    this._CmdCache.RemoveAt(0);
                }
                else if (priority == Priority.High)
                {
                    ISendCommand cmd = this._CmdCache.FirstOrDefault(c => c.Priority == Priority.High);
                    if (cmd != null)
                    {
                        data = cmd.Bytes;
                        this._CmdCache.Remove(cmd);
                    }
                }
                return data;
            }
            finally
            {
                _rwLock.ReleaseReaderLock();
            }
        }

        public byte[] Get(string cmdkey)
        {
            if (this._CmdCache.Count <= 0)
            {
                return new byte[] { };
            }

            _rwLock.AcquireReaderLock(_lockTimeOut);
            try
            {
                ISendCommand cmd = this._CmdCache.FirstOrDefault(c => c.Key == cmdkey);
                if (cmd == null)
                {
                    return new byte[] { };
                }
                else
                {
                    byte[] data = cmd.Bytes;
                    this._CmdCache.Remove(cmd);
                    return data;
                }
            }
            finally
            {
                _rwLock.ReleaseReaderLock();
            }
        }

        /// <summary>
        /// ˳��������
        /// </summary>
        /// <returns></returns>
        public byte[] Get()
        {
            return Get(Priority.Normal);
        }

        public int Count
        {
            get { return _CmdCache.Count; }
        }

        #endregion Methods
    }
}