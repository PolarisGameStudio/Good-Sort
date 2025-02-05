using System;
using System.IO;

namespace BayatGames.SaveGamePro.Serialization.Formatters.Json
{
	public class JsonFormatter : ISaveGameFormatter
	{
		protected SaveGameSettings m_Settings;

		public virtual SaveGameSettings Settings
		{
			get
			{
				return default(SaveGameSettings);
			}
			set
			{
			}
		}

		public JsonFormatter()
		{
		}

		public JsonFormatter(SaveGameSettings settings)
		{
		}

		public string Serialize(object value)
		{
			return null;
		}

		public void Serialize(Stream output, object value)
		{
		}

		public void Serialize(Stream output, object value, SaveGameSettings settings)
		{
		}

		public void Serialize(TextWriter output, object value)
		{
		}

		public void Serialize(TextWriter output, object value, SaveGameSettings settings)
		{
		}

		public T Deserialize<T>(string input)
		{
			return default(T);
		}

		public T Deserialize<T>(Stream input)
		{
			return default(T);
		}

		public T Deserialize<T>(TextReader input)
		{
			return default(T);
		}

		public object Deserialize(string input, Type type)
		{
			return null;
		}

		public object Deserialize(Stream input, Type type)
		{
			return null;
		}

		public object Deserialize(Stream input, Type type, SaveGameSettings settings)
		{
			return null;
		}

		public object Deserialize(TextReader input, Type type)
		{
			return null;
		}

		public object Deserialize(TextReader input, Type type, SaveGameSettings settings)
		{
			return null;
		}

		public void DeserializeInto(Stream input, object value)
		{
		}

		public void DeserializeInto(Stream input, object value, SaveGameSettings settings)
		{
		}

		public void DeserializeInto(TextReader input, object value)
		{
		}

		public void DeserializeInto(TextReader input, object value, SaveGameSettings settings)
		{
		}

		public bool IsTypeSupported(Type type)
		{
			return false;
		}

		public static string SerializeObject(object value)
		{
			return null;
		}

		public static object DeserializeObject(string json, Type type)
		{
			return null;
		}
	}
}
