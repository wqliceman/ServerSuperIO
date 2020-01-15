using System;

namespace ServerSuperIO.Server
{
    public class EqualException : Exception
    {
        public EqualException(string msg) : base(msg)
        {
        }
    }
}