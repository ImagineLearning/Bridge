using Bridge;
using System.Collections;
using System.Collections.Generic;

namespace System
{
    [External]
    public sealed class Array : IEnumerable, ICloneable
    {
        public readonly int Length = 0;

        private Array()
        {
        }

        public object this[int index]
        {
            [External]
            get
            {
                return null;
            }
            [External]
            set
            {
            }
        }

        public extern Array Concat(params object[] items);

        /// <summary>
        /// The indexOf() method returns the first index at which a given element can be found in the array, or -1 if it is not present.
        /// </summary>
        /// <param name="searchElement"></param>
        /// <returns></returns>
        public extern int IndexOf(string searchElement);

        /// <summary>
        /// The indexOf() method returns the first index at which a given element can be found in the array, or -1 if it is not present.
        /// </summary>
        /// <param name="searchElement"></param>
        /// <param name="fromIndex"></param>
        /// <returns></returns>
        public extern int IndexOf(string searchElement, int fromIndex);

        /// <summary>
        /// The lastIndexOf() method returns the last index at which a given element can be found in the array, or -1 if it is not present. The array is searched backwards, starting at fromIndex.
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public extern int LastIndexOf(string searchString);

        /// <summary>
        /// The lastIndexOf() method returns the last index at which a given element can be found in the array, or -1 if it is not present. The array is searched backwards, starting at fromIndex.
        /// </summary>
        /// <param name="searchString"></param>
        /// <param name="fromIndex"></param>
        /// <returns></returns>
        public extern int LastIndexOf(string searchString, int fromIndex);

        public extern string Join();

        public extern string Join(string separator);

        public extern object Pop();

        public extern void Reverse();

        public extern object Shift();

        public extern Array Slice(int start);

        public extern Array Slice(int start, int end);

        public extern Array Splice(int start, int deleteCount, params object[] newItems);

        public extern void Unshift(params object[] items);

        public extern IEnumerator GetEnumerator();

        public extern object GetValue(params int[] indices);

        public extern void SetValue(object value, params int[] indices);

        public extern int GetLength(int dimension);

        public int Rank
        {
            get
            {
                return 0;
            }
        }

        public extern int GetLowerBound(int dimension);

        public extern int GetUpperBound(int dimension);

        public extern IEnumerable ToEnumerable();

        public extern IEnumerable<T> ToEnumerable<T>();

        public extern IEnumerator ToEnumerator();

        public extern IEnumerator<T> ToEnumerator<T>();

        public extern object Clone();

        public static extern T[] Repeat<T>(T value, int count);

        public static extern void Clear<T>(T[] dst, int index, int count);

        public static extern void Copy(Array src, int spos, Array dst, int dpos, int len);

        public static extern void Copy(Array src, Array dst, int len);

        public extern void CopyTo(Array array, int index);

        public extern void CopyTo(Array array, long index);

        public static extern void Resize<T>(T[] array, int newSize);

        public static extern void Reverse(Array array);

        public static extern void Reverse(Array array, int index, int length);

        public static extern int BinarySearch<T>(T[] array, T value);

        public static extern int BinarySearch<T>(T[] array, int index, int length, T value);

        public static extern int BinarySearch<T>(T[] array, T value, IComparer<T> comparer);

        public static extern int BinarySearch<T>(T[] array, int index, int length, T value, IComparer<T> comparer);

        public static extern void Sort<T>(T[] array, int index, int length, IComparer<T> comparer);

        public static extern void Sort<T>(T[] array, int index, int length);

        public static extern void Sort<T>(T[] array);

        public static extern void Sort<T>(T[] array, IComparer<T> comparer);
    }

    [External]
    public static class ArrayExtensions
    {
        public extern static void Push<T>(this T[] source, params T[] values);
    }
}
