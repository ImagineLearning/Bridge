using System;
using System.Collections.Generic;
using System.Linq;
using Bridge;
using TestProject;

namespace Test
{
	public class SpecificActivity
	{

		public void Test1()
		{
			var page = new Page(0);
		}
	}
	
	public class Page : Activity
	{
		private int _num;
		public Page(int num)
		{
			_num = num;
		}
		public void CallMyParentsMethodWithDefaults()
		{
			MethodWithDefaults(1, three: 7);
		}
		public void CallMyParentsMethod()
		{
			MethodWithDefaults();
		}

	}

}
