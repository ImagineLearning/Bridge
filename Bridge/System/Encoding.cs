using Bridge;

namespace System.Text
{
	[External]
	public class Encoding
	{
		public static Encoding UTF8 { get; private set; }
		public static Encoding ASCII { get; private set; }

		public char[] GetChars(byte[] bytes, int offset, int length)
		{
			return null;
		}

		public byte[] GetBytes(char[] chars)
		{
			return null;
		}

		public byte[] GetBytes(string str)
		{
			return null;
		}

		public int GetMaxByteCount(int length)
		{
			return 0;
		}

		public string GetString(byte[] bytes, int length, int offset)
		{
			return null;
		}

		public int GetBytes(string str, int charindex, int charcount, byte[] bytes, int byteindex)
		{
			return 0;
		}
	}

}