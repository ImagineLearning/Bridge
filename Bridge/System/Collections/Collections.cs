using Bridge;

namespace System.Collections.Generic
{
	[External]
	public class Stack<T> : IEnumerable<T>, ICollection, IEnumerable
	{

		public Stack()
		{
		}

		public Stack(IEnumerable<T> collection)
		{

		}

		public Stack(int capacity)
		{

		}
		public int Count { get { return 0; } }

		public void Clear()
		{
		}

		public bool Contains(T item)
		{
			return false;
		}

		public void CopyTo(T[] array, int arrayIndex)
		{

		}

		public T Peek()
		{
			return default(T);
		}

		public T Pop()
		{
			return default(T);
		}

		public void Push(T item)
		{

		}

		public T[] ToArray()
		{
			return null;
		}

		public void TrimExcess()
		{

		}

		public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			public void Reset()
			{

			}

			object IEnumerator.Current
			{
				get { return Current; }
			}

			public T Current { get { return default(T); } }

			public void Dispose()
			{

			}

			public bool MoveNext()
			{
				return false;
			}
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	[External]
	public class Queue<T> : IEnumerable<T>
	{
		public Queue()
		{
			
		}

		public Queue(int size)
		{
			
		}

		public Queue(T[] source)
		{
			
		}
		public IEnumerator<T> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Enqueue(T target)
		{
			
		}

		public T Dequeue()
		{
			return default(T);
		}

		public int Count { get { return 0; } }

		public void Clear()
		{
			
		}
	}

	[External]
	public class HashSet<T> : IEnumerable<T>
	{
		public HashSet()
		{
			
		}
		public HashSet (IEnumerable<T> source)
		{
			
		}

		public bool Add(T item)
		{
			return false;
		}

		public bool Remove(T item)
		{
			return false;
		}

		public void Clear()
		{
			
		}

		public IEnumerator<T> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public bool Contains(T item)
		{
			return false;
		}

		public int Count { get; private set; }
	}

	[External]
	public class LinkedList<T>
	{

		public void AddFirst(T value)
		{
			
		}

		public void AddLast(T value)
		{
			
		}

		public LinkedListNode<T> First { get; private set; }
		public LinkedListNode<T> Last { get; private set; }
		public int Count { get; private set; }

		public void RemoveFirst()
		{
			
		}

		public void Clear()
		{
			
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}
	}

	[External]
	public class LinkedListNode<T>
	{
		public T Value { get; private set; }
	}

	[External]
	public class SortedDictionary<TKey, TValue> : IDictionary<TKey, TValue>
	{
		public SortedDictionary()
		{

		} 
		public SortedDictionary(StringComparer comparer)
		{
			
		} 
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public bool ContainsKey(TKey key)
		{
			throw new NotImplementedException();
		}

		public void Add(TKey key, TValue value)
		{
			throw new NotImplementedException();
		}

		public bool Remove(TKey key)
		{
			throw new NotImplementedException();
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			throw new NotImplementedException();
		}

		public TValue this[TKey key]
		{
			get { throw new NotImplementedException(); }
			set { throw new NotImplementedException(); }
		}

		public new ICollection<TKey> Keys { get; private set; }
		public ICollection<TValue> Values { get; private set; }
		public int Count { get; private set; }
	}

	[External]
	public interface IList
	{
		void Add(object value);
	}

	[External]
	public static class IEnumerableExtensions
	{
		public static bool TrueForAll<T>(this List<T> items, Predicate<T> match)
		{
			return false;
		}

		public static List<T> FindAll<T>(this List<T> data, Predicate<T> predicate)
		{
			return null;
		}

		public static void ForEach<T>(this List<T> list, Action<T> action)
		{
			
		}

		public static int FindIndex<T>(this List<T> list, Predicate<T> match)
		{
			return 0;
		}

		//public static IEnumerable<T> Concat<T>(this IEnumerable<T> first, IEnumerable<T> second)
		//{
		//	return null;
		//}

		//public static T[] ToArray<T>(this IEnumerable<T> collection)
		//{
		//	return null;
		//}
	}
}