namespace Test
{
	public class ClassWithProperties
	{
		private int _publicInt;
		public int PublicInt
		{
			get { return _publicInt; }
			set { _publicInt = value; }
		}

		private int _protectedInt;
		protected int ProtectedInt
		{
			get { return _protectedInt; }
			set { _protectedInt = value; }
		}

		private int _privateInt;
		private int PrivateInt
		{
			get { return _privateInt; }
			set { _privateInt = value; }
		}
	}
}
