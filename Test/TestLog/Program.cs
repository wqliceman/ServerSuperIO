using ServerSuperIO.Log;
using System;

namespace TestLog
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new LogFactory().GetLog("ddd").Debug(true, "ddd");
            Console.Read();
        }
    }
}