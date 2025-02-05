using System.Collections.Generic;
using BayatGames.SaveGamePro.Serialization;

namespace BayatGames.SaveGamePro
{
	public class MetaData : ISavable
	{
		protected Dictionary<string, string> data;

		public bool Has(string key)
		{
			return false;
		}

		public T Get<T>(string key)
		{
			return default(T);
		}

		public void Set(string key, object value)
		{
		}

		public void OnWrite(ISaveGameWriter writer)
		{
		}

		public void OnRead(ISaveGameReader reader)
		{
		}
	}
}
