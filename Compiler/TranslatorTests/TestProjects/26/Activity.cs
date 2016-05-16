using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bridge;

namespace TestProject
{
	[External]
	public abstract class Activity
	{
		protected Activity()
		{
		}

		public virtual void MethodWithDefaults(int one = 0, int two = 2, int three = 3, int four = 4, object five = null)
		{
		}
	}
}
