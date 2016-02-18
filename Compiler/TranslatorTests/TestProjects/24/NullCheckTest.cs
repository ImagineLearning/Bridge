using System;

namespace Test
{
	public class NullCheckTest
	{
		public AnotherClass MyNullClass = null;

		public void CheckForNullTest()
		{
			if (MyNullClass != null)
			{
				throw new NotImplementedException();
			}

			if (MyNullClass == null)
			{
				throw new NotImplementedException();
			}
		}
	}

	public class AnotherClass
	{
		
	}
}
