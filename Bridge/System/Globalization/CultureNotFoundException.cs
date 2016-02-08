using Bridge;

namespace System.Globalization
{
    [External]
    
    public class CultureNotFoundException : ArgumentException, IBridgeClass
    {
        public extern CultureNotFoundException();

        
        public extern CultureNotFoundException(string message);

        
        public extern CultureNotFoundException(string message, Exception innerException);

        
        public extern CultureNotFoundException(string paramName, string message);

        
        public extern CultureNotFoundException(string message, string invalidCultureName, Exception innerException);

        
        public extern CultureNotFoundException(string paramName, string invalidCultureName, string message);

        
        public extern CultureNotFoundException(string message, int invalidCultureId, Exception innerException);

        
        public extern CultureNotFoundException(string paramName, int invalidCultureId, string message);

        public extern string InvalidCultureName { get; }

        public extern int? InvalidCultureId { get; }
        
    }
}
