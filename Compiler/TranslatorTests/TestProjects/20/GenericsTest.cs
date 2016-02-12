using System;
using System.Collections.Generic;

namespace Test
{
	public class GenericsTest
	{
		public List<string> GenericListTest()
		{
			return new List<string>();
		}

		public Dictionary<string, int> GenericDictionaryTest()
		{
			return new Dictionary<string, int>();
		}

		public List<TestClass1> GenericListTest2()
		{
			return new List<TestClass1>();
		}

		public Dictionary<TestClass1, TestClass2> GenericDictionaryTest2()
		{
			return new Dictionary<TestClass1, TestClass2>();
		}

		

	}

	public class TestClass1
	{
		
	}

	public class TestClass2
	{
		
	}
}
