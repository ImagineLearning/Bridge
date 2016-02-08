using Bridge;

namespace System.Collections.Generic
{
    [External]
    public interface IEnumerator<out T> : IDisposable, IEnumerator
    {
        new T Current
        {
            get;
        }
    }
}
