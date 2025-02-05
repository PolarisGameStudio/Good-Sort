using System;
using System.IO;
using System.Runtime.Serialization;

namespace BayatGames.SaveGamePro.Serialization.Formatters.Json
{
	public class JsonTextWriter : JsonWriter
	{
		protected TextWriter m_Writer;

		protected bool m_IsFirstProperty;

		protected bool m_Wrap;

		public virtual TextWriter Writer => null;

		public JsonTextWriter(TextWriter writer, SaveGameSettings settings)
			: base(default(SaveGameSettings))
		{
		}

		public override void Write(object value)
		{
		}

		public override void WriteProperty(string identifier, object value)
		{
		}

		protected virtual void WriteObject(object value, Type type)
		{
		}

		public override void WriteSavableMembers(object obj, Type type)
		{
		}

		public virtual void WriteSavableFields(object obj, Type type, ref bool isFirst)
		{
		}

		public virtual void WriteSavableProperties(object obj, Type type, ref bool isFirst)
		{
		}

		protected virtual void WriteSerializationInfo(SerializationInfo info)
		{
		}

		public override void Dispose()
		{
		}
	}
}
