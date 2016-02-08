using Bridge;

namespace System.Collections
{
    [External]
    
    public interface IEnumerable
    {
        
        IEnumerator GetEnumerator();
    }
}
