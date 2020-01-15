using System;

namespace ServerSuperIO.Log
{
    public class ConsoleContainer : ILogContainer
    {
        public void ShowLog(string log)
        {
            Console.WriteLine(log);
        }
    }
}