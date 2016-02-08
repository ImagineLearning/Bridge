using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Text;
using Bridge;

namespace System
{
	[External]
	public class AggregateException : Exception 
    {
		public extern AggregateException();

		
		public extern AggregateException(IEnumerable<Exception> innerExceptions);

        
		public extern AggregateException(params Exception[] innerExceptions);

		public extern AggregateException(string message);

		public extern AggregateException(string message, IEnumerable<Exception> innerExceptions);

		
		public extern AggregateException(string message, params Exception[] innerExceptions);

	    [FieldProperty]
	    public extern ReadOnlyCollection<Exception> InnerExceptions
	    {
	        get;
	    }

		public extern AggregateException Flatten();

        public extern void Handle(Func<Exception, bool> predicate);
    }
}
