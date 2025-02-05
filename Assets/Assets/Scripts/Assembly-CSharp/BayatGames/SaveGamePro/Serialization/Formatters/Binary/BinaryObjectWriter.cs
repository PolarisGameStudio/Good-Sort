using System;
using System.IO;
using System.Runtime.Serialization;

namespace BayatGames.SaveGamePro.Serialization.Formatters.Binary
{
	public class BinaryObjectWriter : IDisposable, ISaveGameWriter
	{
		protected BinaryWriter m_Writer;

		protected SaveGameSettings m_Settings;

		public virtual BinaryWriter Writer => null;

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

		public BinaryObjectWriter(Stream stream, SaveGameSettings settings)
		{
		}

		public BinaryObjectWriter(BinaryWriter writer, SaveGameSettings settings)
		{
		}

		public virtual void Write<T>(T value)
		{
		}

		public virtual void Write(object value)
		{
		}

		public virtual void WriteProperty<T>(string identifier, T value)
		{
		}

		public virtual void WriteProperty(string identifier, object value)
		{
		}

		protected virtual void WriteObject(object value, Type type)
		{
		}

		public virtual void WriteSavableMembers(object value, Type type)
		{
		}

		public virtual void WriteSavableFields(object value, Type type)
		{
		}

		public virtual void WriteSavableProperties(object value, Type type)
		{
		}

		protected virtual void WriteSerializationInfo(SerializationInfo info)
		{
		}

		public virtual void Dispose()
		{
		}
	}
}
