namespace Test
{
	public class ClassWithNullable
	{
		private int? _myNullableInt;
		public bool? MyNullableBool;

		public void Test1()
		{
			if (MyNullableBool == true)
			{
				_myNullableInt = 100;
			}

			if (_myNullableInt > 99)
			{
				MyNullableBool = false;
			}

			if (_myNullableInt == 100)
			{
				_myNullableInt = 101;
			}
		}
	}
}
