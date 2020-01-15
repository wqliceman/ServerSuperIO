using System;

namespace TestLog
{
    [Serializable]
    public class Class1 : ServerSuperIO.Device.DeviceParameter
    {
        public Class1()
        {
            mystring = "string";
        }

        public string mystring { get; set; }

        public override object Repair()
        {
            throw new NotImplementedException();
        }
    }
}