using System;

namespace BayatGames.SaveGamePro.Serialization.Formatters.Json
{
	public abstract class JsonWriter : IDisposable, ISaveGameWriter
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

		public JsonWriter(SaveGameSettings settings)
		{
		}

		public virtual void Write<T>(T value)
		{
		}

		public abstract void Write(object value);

		public virtual void WriteProperty<T>(string identifier, T value)
		{
		}

		public abstract void WriteProperty(string identifier, object value);

		public abstract void WriteSavableMembers(object obj, Type type);

		public abstract void Dispose();
	}
}
