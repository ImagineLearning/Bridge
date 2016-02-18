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
	}

}
