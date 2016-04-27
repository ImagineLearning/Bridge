using System;
using System.Collections.Generic;
using System.Linq;
using Bridge;

namespace Test
{
	public class ToConstructors
	{

		public void Test1()
		{
			var i = 500;

			var str = i.ToString();

			var length = str.Length;

			var eye = Convert.ToInt32(str);

			var equal = i == eye;

			var list = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

			var greaterThan6 = list.Select(x => x > 5).ToList();

			var numGreaterThan6 = greaterThan6.Count;

			var page = new Page(0);
		}
	}

	[ObjectLiteral]
	public class Page
	{
		private int _num;
		public Page(int num)
		{
			_num = num;
		}

		public int PageNum
		{
			get { return _num; }
			set { _num = value; }
		}
	}

}
