using Bridge;

namespace System.Collections
{
    [External]
    
    public interface ICollection : IEnumerable
    {
        int Count
        {
            
            get;
        }
    }
}
