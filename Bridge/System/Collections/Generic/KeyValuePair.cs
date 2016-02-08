using Bridge;

namespace System.Collections.Generic
{
    [External]
    public class KeyValuePair<TKey, TValue>
    {
        public extern KeyValuePair(TKey key, TValue value);

        [FieldProperty]
        public extern TKey Key
        {
            get;
        }

        [FieldProperty]
        public extern TValue Value
        {
            get;
        }
    }
}
