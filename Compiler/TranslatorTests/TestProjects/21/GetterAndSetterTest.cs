using System;

namespace Test
{
	public class GetterSetterTest
	{
		public int MyInt { get; set; }
		public bool MyBool { get; private set; }

		public void Test1()
		{
			var i = MyInt;
			MyInt = 20;
		}

		public void Test2()
		{
			var isTrue = MyBool;
			MyBool = true;
		}
	}

	public class AnotherClass
	{
		public GetterSetterTest GetterSetterTest;

		public void Test3()
		{
			var i = GetterSetterTest.MyInt;
			GetterSetterTest.MyInt = 20;
		}

		public void Test4()
		{
			var isTrue = GetterSetterTest.MyBool;
		}
	}
}
