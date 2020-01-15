using System.Collections.Concurrent;

namespace ServerSuperIO.Base
{
    public class Manager<TKey, TValue> : ConcurrentDictionary<TKey, TValue>
    {
    }
}