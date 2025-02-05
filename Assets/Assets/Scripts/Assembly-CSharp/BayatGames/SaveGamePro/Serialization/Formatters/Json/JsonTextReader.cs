using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace BayatGames.SaveGamePro.Serialization.Formatters.Json
{
	public class JsonTextReader : JsonReader
	{
		protected TextReader m_Reader;

		protected string m_Json;

		protected int m_Position;

		protected bool m_IsFirstProperty;

		public virtual TextReader Reader => null;

		public override IEnumerable<string> Properties => null;

		public JsonTextReader(TextReader reader, SaveGameSettings settings)
			: base(default(SaveGameSettings))
		{
		}

		public override object Read(Type type)
		{
			return null;
		}

		public override void ReadInto(object value)
		{
		}

		public virtual GameObject ReadChild(GameObject parent)
		{
			return null;
		}

		public override object ReadProperty(Type type)
		{
			return null;
		}

		public override void ReadIntoProperty(object value)
		{
		}

		protected virtual string[] GetProperties()
		{
			return null;
		}

		protected virtual int GetObjectLength()
		{
			return 0;
		}

		protected virtual int GetArrayLength()
		{
			return 0;
		}

		protected virtual string PeekString()
		{
			return null;
		}

		protected virtual string ReadString()
		{
			return null;
		}

		protected virtual string ReadQoutedString()
		{
			return null;
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

		public override void ReadSavableMembers(object obj, Type type)
		{
		}

		public override void ReadIntoSavableMembers(object obj, Type type)
		{
		}

		public override void Dispose()
		{
		}
	}
}
