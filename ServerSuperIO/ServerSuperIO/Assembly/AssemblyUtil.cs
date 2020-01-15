using System;
using System.IO;

namespace ServerSuperIO.Common.Assembly
{
    public class AssemblyUtil
    {
        public static string GetAssemblyVersion(string path)
        {
            if (File.Exists(path))
            {
                System.Reflection.Assembly asm = System.Reflection.Assembly.LoadFile(path);
                return asm.GetName().Version.ToString();
            }
            else
            {
                return String.Empty;
            }
        }
    }
}