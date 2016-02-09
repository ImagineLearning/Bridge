using Bridge;

namespace System
{
	[External]
	public class Random
	{
		public int Next(int max)
		{
			return (int)(Math.Random()*max);
		}

		public int Next(int min, int max)
		{
			return min + (int)(Math.Random() * (max - min));
		}

		public double NextDouble()
		{
			return Math.Random();
		}
	}

}