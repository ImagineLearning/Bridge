using System;
using System.Collections.Generic;
using System.Linq;
using Bridge;

namespace Test
{
	public class DebuggingTest
	{

		public void Test1()
		{
			var page = new Page(0);
			page.GetPage();
		}
	}
	
	public class Page 
	{
		private readonly int _num;
		public Page(int num)
		{
			_num = num;
		}
		public int GetPage()
		{
			return _num;
		}

	}

}
