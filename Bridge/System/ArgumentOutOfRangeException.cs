using Bridge;

namespace System
{
    [External]
    
    public class ArgumentOutOfRangeException : ArgumentException, IBridgeClass
    {
        public ArgumentOutOfRangeException()
        {
        }

        public ArgumentOutOfRangeException(string paramName)
        {
        }

        
        public ArgumentOutOfRangeException(string message, Exception innerException)
        {
        }

        public ArgumentOutOfRangeException(string paramName, string message)
        {
        }

        
        public ArgumentOutOfRangeException(string paramName, object actualValue, string message)
        {
        }

        public object ActualValue
        {
            get
            {
                return null;
            }
        }
    }
}
