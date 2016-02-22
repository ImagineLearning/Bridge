using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
	public class IndexerGetSetTests
	{
		public void Test1()
		{
			var dictionary = new Dictionary<string, object>();
			dictionary.Add("key", 1);
			dictionary.Add("key2", 2);

			var val1 = dictionary["key"];
			var val2 = dictionary["key2"];

			dictionary["key2"] = 22;
		}

		public void Test2()
		{
			var list = new List<string>();
			list.Add("string1");
			list.Add("string2");

			var val1 = list[0];
			var val2 = list[1];

			list[1] = "string3";
		}
	}

}
