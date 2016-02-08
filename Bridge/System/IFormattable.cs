using Bridge;

namespace System
{
    [External]
    
    public interface IFormattable : IBridgeClass
    {
        
        string Format(string format, IFormatProvider formatProvider);
    }
}
