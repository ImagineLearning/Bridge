using Bridge;

namespace System.Collections.Generic
{
    [External]
    public interface IEnumerable<out T> : IEnumerable
    {
        new IEnumerator<T> GetEnumerator();
    }
}
