using System;
using System.Collections.Generic;
using Bridge;

namespace EventHandlerExtensions
{
	[External]
	public static class EventHandlerExtensions
	{
		public static IEnumerable<EventHandler> GetInvocationList(this EventHandler eventHandler)
		{
			return null;
		}
	}

}