using Bridge;

namespace Test
{
	public class ExternalConstructorTest
	{

		public void Test1()
		{
			var page = new Page(0);
			page.GetPage();

			var page2 = new Page2(0);
			page2.GetPage();
		}
	}
	
	public class Page 
	{
		private readonly int _num;

		public Page()
		{
			_num = 0;
		}

		public Page(int num)
		{
			_num = num;
		}

		[External]
		public Page(int num, int num2)
		{
			_num = num;
			_num = num2;
		}

		public int GetPage()
		{
			return _num;
		}

	}

	public class Page2
	{
		private readonly int _num;

		[External]
		public Page2()
		{
			_num = 0;
		}

		public Page2(int num)
		{
			_num = num;
		}

		[External]
		public Page2(int num, int num2)
		{
			_num = num;
			_num = num2;
		}

		public int GetPage()
		{
			return _num;
		}

	}
}
