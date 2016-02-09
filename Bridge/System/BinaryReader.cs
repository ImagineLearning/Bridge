using Bridge;

namespace System.IO
{
	[External]
	public class BinaryReader : IDisposable
	{
		public BinaryReader()
		{
			
		}

		public BinaryReader(Stream stream)
		{
			
		}

		public Stream BaseStream { get; private set; }

		public byte[] ReadBytes(int lenght)
		{
			return null;
		}

		public byte ReadByte()
		{
			return 0;
		}

		public void Dispose()
		{
			
		}

		public char[] ReadChars(int numChars)
		{
			return null;
		}

		public string ReadString()
		{
			return null;
		}

		public char ReadChar()
		{
			return default(char);
		}

		public Int16 ReadInt16()
		{
			return default(Int16);
		}

		public Int32 ReadInt32()
		{
			return default(Int32);
		}
	}


}