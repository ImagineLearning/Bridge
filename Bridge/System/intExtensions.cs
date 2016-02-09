using System.Globalization;
using Bridge;

namespace System
{
	[External]
	public static class IntExtensions
	{
		public static string ToString(this int val, CultureInfo cultureInfo)
		{
			return val.ToString();
		}
	}

}