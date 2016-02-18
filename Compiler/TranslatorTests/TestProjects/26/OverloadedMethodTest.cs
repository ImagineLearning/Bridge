using System;

namespace Test
{
	public class OverloadedMethodTest
	{
		public ClassWithOverloadedMethod MyClass;

		public void CallOverloadedMethodsTest()
		{
			MyClass.InitializeAudio("lets_go", 2);
			MyClass.InitializeAudio("mediaset", "lets_go", 2);
		}
	}

	public class ClassWithOverloadedMethod
	{
		public void InitializeAudio(string mediaName, int audioType, int requirement = 0,
			bool waitForDownload = true)
		{
			throw new NotImplementedException();
		}

		public void InitializeAudio(string mediaSet, string mediaName, int audioType, int requirement = 0,
			bool waitForDownload = true)
		{
			throw new NotImplementedException();
		}
	}
}
