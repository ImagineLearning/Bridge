using Bridge;

namespace System.Collections.Generic
{
    [External]
    
    public interface IEqualityComparer<in T> : IBridgeClass
    {
        
        bool Equals(T x, T y);

        
        int GetHashCode(T obj);
    }

    [External]
    
    public abstract class EqualityComparer<T> : IEqualityComparer<T>, IBridgeClass
    {
        public static EqualityComparer<T> Default
        {
            
            get
            {
                return null;
            }
        }

        
        public virtual extern bool Equals(T x, T y);

        
        public virtual extern int GetHashCode(T obj);
    }
}
