using System;
using System.Collections.Generic;

namespace BayatGames.SaveGamePro.Serialization.Formatters.Json
{
	public abstract class JsonReader : IDisposable, ISaveGameReader
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

		public abstract IEnumerable<string> Properties { get; }

		public JsonReader(SaveGameSettings settings)
		{
		}

		public virtual T Read<T>()
		{
			return default(T);
		}

		public abstract object Read(Type type);

		public virtual void ReadInto<T>(T value)
		{
		}

		public abstract void ReadInto(object value);

		public virtual T ReadProperty<T>()
		{
			return default(T);
		}

		public abstract object ReadProperty(Type type);

		public virtual void ReadIntoProperty<T>(T value)
		{
		}

		public abstract void ReadIntoProperty(object value);

		public abstract void ReadSavableMembers(object obj, Type type);

		public abstract void ReadIntoSavableMembers(object obj, Type type);

		public abstract void Dispose();
	}
}
