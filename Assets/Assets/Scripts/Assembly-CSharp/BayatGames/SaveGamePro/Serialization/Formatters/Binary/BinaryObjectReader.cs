using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace BayatGames.SaveGamePro.Serialization.Formatters.Binary
{
	public class BinaryObjectReader : IDisposable, ISaveGameReader
	{
		protected BinaryReader m_Reader;

		protected SaveGameSettings m_Settings;

		public virtual BinaryReader Reader => null;

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

		public virtual IEnumerable<string> Properties => null;

		public BinaryObjectReader(Stream stream, SaveGameSettings settings)
		{
		}

		public BinaryObjectReader(BinaryReader reader, SaveGameSettings settings)
		{
		}

		public virtual T Read<T>()
		{
			return default(T);
		}

		public virtual object Read(Type type)
		{
			return null;
		}

		public virtual void ReadInto<T>(T value)
		{
		}

		public virtual void ReadInto(object value)
		{
		}

		public virtual GameObject ReadChild(GameObject parent)
		{
			return null;
		}

		public virtual T ReadProperty<T>()
		{
			return default(T);
		}

		public virtual object ReadProperty(Type type)
		{
			return null;
		}

		public virtual void ReadIntoProperty<T>(T value)
		{
		}

		public virtual void ReadIntoProperty(object value)
		{
		}

		protected virtual string[] GetProperties()
		{
			return null;
		}

		protected virtual string SkipProperty()
		{
			return null;
		}

		public virtual bool Skip(Type type)
		{
			return false;
		}

		protected virtual object ReadObject(Type type)
		{
			return null;
		}

		protected virtual void ReadObject(Type type, object result)
		{
		}

		protected virtual void ReadIntoObject(Type type, object result)
		{
		}

		public virtual void ReadSavableMembers(object obj, Type type)
		{
		}

		public virtual void ReadIntoSavableMembers(object obj, Type type)
		{
		}

		public virtual void Dispose()
		{
		}
	}
}
