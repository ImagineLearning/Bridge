using Bridge;

namespace System
{
    [External]
    
    public interface IComparable : IBridgeClass
    {
        
        int CompareTo(Object obj);
    }

    [External]
    
    public interface IComparable<in T> : IBridgeClass
    {
        
        int CompareTo(T other);
    }
}
