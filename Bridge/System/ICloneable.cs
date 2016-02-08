using Bridge;

namespace System
{
    
    [External]
    public interface ICloneable : IBridgeClass
    {
        
        object Clone();
    }
}
