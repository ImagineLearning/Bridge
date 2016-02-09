using System;
using System.Runtime.CompilerServices;
using Bridge;

namespace System.Diagnostics 
{
	[External]
	public static class Debug
	{

		public static void Assert(bool condition)
		{
		}

		public static void Assert(bool condition, string message)
		{
		}

		public static void Fail(string message)
		{
		}

		public static void WriteLine(string message)
		{
		}

		public static void Break()
		{
		}
	}
}
