using Bridge;
using System;
using System.Collections;

namespace Test
{
	[External]
	public interface IDynamicDataProvider
	{
		void LoadJson(string json);
		void LoadJsonFile(string json);
		Object ParsedObjects { get; set; }
	}

	public class SoundCheckData
	{
		public int NumberOfSounds { get; set; }
	}

	public class ExternalConstructorTest2
	{

		public void Test1()
		{
			var page = new SoundCheckDataProvider(new DDP());
			page.GetWordsForDataSet(21);
		}
	}

	public class DDP : IDynamicDataProvider
	{

		public void LoadJson(string json) {}

		public void LoadJsonFile(string json) {}

		public object ParsedObjects
		{
			get { return null; }
			set {}
		}
	}

	public class SoundCheckDataProvider
	{
		public static readonly string SoundCheckJsonPath = "DynamicData/SoundCheck.json";
		private readonly IDynamicDataProvider _dynamicDataProvider;

		public SoundCheckDataProvider(IDynamicDataProvider dynamicDataProvider)
		{
			_dynamicDataProvider = dynamicDataProvider;
			if (_dynamicDataProvider.ParsedObjects == null)
			{
				_dynamicDataProvider.LoadJsonFile(SoundCheckJsonPath);
			}
		}


		[External]
		public SoundCheckDataProvider(string json, IDynamicDataProvider dynamicDataProvider)
			: this(dynamicDataProvider)
		{
			_dynamicDataProvider.LoadJson(json);
		}

		public SoundCheckData[] GetWordsForDataSet(int dataSetNum)
		{
			if (dataSetNum == 21)
			{
				return new[]
				{
					new SoundCheckData { NumberOfSounds = 5 },
					new SoundCheckData { NumberOfSounds = 3 },
					new SoundCheckData { NumberOfSounds = 3 },
					new SoundCheckData { NumberOfSounds = 3 },
					new SoundCheckData { NumberOfSounds = 4 }
				};
			}

			
			return null;
		}
	}
}
