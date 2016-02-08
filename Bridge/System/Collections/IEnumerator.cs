using Bridge;

namespace System.Collections
{
    [External]
    public interface IEnumerator
    {
        object Current
        {
            get;
        }

        bool MoveNext();

        void Reset();
    }
}
