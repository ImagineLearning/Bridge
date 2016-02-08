using Bridge;

namespace System
{
    [External]
    public interface IEquatable<in T> : IBridgeClass
    {

        bool Equals(T other);
    }
}
