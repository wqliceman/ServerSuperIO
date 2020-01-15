using System;

namespace ServerSuperIO.Server
{
    public class NotEqualException : Exception
    {
        public NotEqualException(string msg) : base(msg)
        {
        }
    }
}