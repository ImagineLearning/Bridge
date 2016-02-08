using Bridge;

namespace System.Collections.Generic
{
    
    public abstract class Comparer<T> : IComparer<T>
    {
        public static Comparer<T> Default
        {
            
            get
            {
                return null;
            }
        }

        public abstract int Compare(T x, T y);

        
        public static extern Comparer<T> Create(Comparison<T> comparison);
    }
}
