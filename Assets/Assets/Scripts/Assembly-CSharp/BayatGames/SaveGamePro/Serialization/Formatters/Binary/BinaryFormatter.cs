using System;
using System.IO;

namespace BayatGames.SaveGamePro.Serialization.Formatters.Binary
{
	public class BinaryFormatter : ISaveGameFormatter
	{
		public const byte PropertyStart = 100;

		public const byte PropertyEnd = 101;

		public const byte SaveGameTypeStart = 102;

		public const byte SaveGameTypeEnd = 103;

		public const byte Terminator = 104;

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

		public BinaryFormatter()
		{
		}

		public BinaryFormatter(SaveGameSettings settings)
		{
		}

		public virtual byte[] Serialize(object value)
		{
			return null;
		}

		public virtual void Serialize(Stream output, object value)
		{
		}

		public virtual void Serialize(Stream output, object value, SaveGameSettings settings)
		{
		}

		public virtual T Deserialize<T>(Stream input)
		{
			return default(T);
		}

		public virtual T Deserialize<T>(Stream input, SaveGameSettings settings)
		{
			return default(T);
		}

		public virtual T Deserialize<T>(byte[] buffer)
		{
			return default(T);
		}

		public virtual object Deserialize(byte[] buffer, Type type)
		{
			return null;
		}

		public virtual object Deserialize(Stream input, Type type)
		{
			return null;
		}

		public virtual object Deserialize(Stream input, Type type, SaveGameSettings settings)
		{
			return null;
		}

		public virtual void DeserializeInto(Stream input, object value)
		{
		}

		public virtual void DeserializeInto(Stream input, object value, SaveGameSettings settings)
		{
		}

		public virtual bool IsTypeSupported(Type type)
		{
			return false;
		}

		public static byte[] SerializeObject(object value)
		{
			return null;
		}

		public static void SerializeObject(Stream output, object value)
		{
		}

		public static object DeserializeObject(byte[] buffer, Type type)
		{
			return null;
		}

		public static object DeserializeObject(Stream input, Type type)
		{
			return null;
		}
	}
}
