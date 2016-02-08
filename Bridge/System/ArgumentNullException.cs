using Bridge;

namespace System
{
    [External]
    
    public class ArgumentNullException : ArgumentException, IBridgeClass
    {
        public ArgumentNullException()
        {
        }

        public ArgumentNullException(string paramName)
        {
        }

        public ArgumentNullException(string paramName, string message)
        {
        }

        
        public ArgumentNullException(string message, Exception innerException)
        {
        }
    }
}
