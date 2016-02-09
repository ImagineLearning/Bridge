using Bridge;

namespace System.IO
{
	[External]
	public class Stream : IDisposable
	{
		public void WriteByte(byte toWrite)
		{

		}

		public long Position { get; private set; }
		public long Length { get; private set; }

		public void SetLength(int length)
		{

		}

		public void Dispose()
		{
			
		}

		public void Seek(int offset, SeekOrigin origin)
		{
			
		}

	}

	[External]
	public enum SeekOrigin
	{
		Begin
	}
}