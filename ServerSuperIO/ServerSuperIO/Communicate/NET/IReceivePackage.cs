using System.Collections.Generic;

namespace ServerSuperIO.Communicate.NET
{
    public interface IReceivePackage
    {
        string RemoteIP { get; set; }
        int RemotePort { get; set; }
        IList<IRequestInfo> RequestInfos { get; set; }
        // string DeviceCode { get; set; }
    }
}