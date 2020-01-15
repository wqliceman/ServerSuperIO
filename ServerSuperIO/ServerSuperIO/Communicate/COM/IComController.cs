namespace ServerSuperIO.Communicate.COM
{
    internal interface IComController : IController
    {
        IComSession ComChannel { get; set; }
    }
}