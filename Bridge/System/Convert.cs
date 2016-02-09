using Bridge;

namespace System
{
	//NOTE: support is coming for this in version 1.11 of Bridge.net
	//right now its used mostly in data providers which don't need to be javascript immediately
	[External]
	public static class Convert
	{
		public static int ToInt32(object obj)
		{
			return 0;
		}

		public static int ToInt32(object obj, int fromBase)
		{
			return 0;
		}

		public static double ToDouble(object obj)
		{
			return 0;
		}

		public static float ToSingle(object obj)
		{
			return 0;
		}

		public static string ToString(object obj)
		{
			return null;
		}

		public static short ToInt16(object obj)
		{
			return 0;
		}
		public static short ToInt16(object obj, int fromBase)
		{
			return 0;
		}

		public static bool ToBoolean(object obj)
		{
			return false;
		}

		public static byte ToByte(object obj)
		{
			return 0;
		}

		public static char ToChar(object obj)
		{
			return default(char);
		}

		public static DateTime ToDateTime(object obj)
		{
			return default(DateTime);
		}

		public static Decimal ToDecimal(object obj)
		{
			return default(Decimal);
		}

		public static long ToInt64(object obj)
		{
			return 0;
		}

		public static long ToInt64(object obj, int fromBase)
		{
			return 0;
		}

		public static string ToBase64String(object obj)
		{
			return null;
		}

	}


}