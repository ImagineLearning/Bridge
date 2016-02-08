using Bridge;
using System.Collections.Generic;

namespace System.Linq
{
    [External]
    [IgnoreGeneric]
    public interface IGrouping<out TKey, TElement> : IEnumerable<TElement>
    {
        TKey Key
        {
            [Template("Key")]
            get;
        }
    }

    [External]
    [IgnoreGeneric]
    public class Grouping<TKey, TElement> : EnumerableInstance<TElement>, IGrouping<TKey, TElement>
    {
        internal Grouping()
        {
        }

        public TKey Key
        {
            [Template("Key")]
            get
            {
                return default(TKey);
            }
        }
    }
}
