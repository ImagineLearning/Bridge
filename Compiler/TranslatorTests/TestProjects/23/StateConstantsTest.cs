using System;

namespace Test
{
	public class StateConstantsTest
	{
		public const int StateOne = 1;
		public static int StaticInt = 2;

		public void AccessConstantTest()
		{
			var value = StateOne;
			var value2 = StaticInt;
		}
	}

	public class Node<T>
	{
		public T myValue;
		public const int AnInteger = 0;

		public Node(T val)
		{
			myValue = val;
			var value3 = AnInteger;
		}
	}
}
