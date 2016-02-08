using System.Runtime.CompilerServices;
using System.Threading;
using Bridge;

namespace System
{
	[External]
	
	public class OperationCanceledException : Exception 
    {
		public extern OperationCanceledException();

		
		public extern OperationCanceledException(CancellationToken token);

        
		public extern OperationCanceledException(string message);

        
		public extern OperationCanceledException(string message, Exception innerException);

		public extern OperationCanceledException(string message, CancellationToken token);

        
		public extern OperationCanceledException(string message, Exception innerException, CancellationToken token);

	    [FieldProperty]
	    public extern CancellationToken CancellationToken
	    {
	        get;
            private set;
	    }
	}
}
