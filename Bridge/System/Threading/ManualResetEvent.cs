using Bridge;

namespace System.Threading
{
	[External]
	public class ManualResetEvent
	{
		public ManualResetEvent(bool initialState)
		{

		}

		public void Set()
		{

		}

		public bool WaitOne(int millisecondsTimeout = 0)
		{
			return false;
		}
	}
}