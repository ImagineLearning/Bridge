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
}
