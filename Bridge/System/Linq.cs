using System.Collections.Generic;
using Bridge;

namespace System.LinqMock
{
	[External]
	public class EnumerableInstance<TElement>
	{
		public TElement[] ToArray()
		{
			return null;
		}
	}

	[External]
	public static class Enumerable
	{
		public static EnumerableInstance<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source,
			Func<TSource, int, TResult> selector)
		{
			return null;
		}

		public static EnumerableInstance<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source,
			Func<TSource, TResult> selector)
		{
			return null;
		}
	}

	[External]
	public class Linq
	{
	}
}
