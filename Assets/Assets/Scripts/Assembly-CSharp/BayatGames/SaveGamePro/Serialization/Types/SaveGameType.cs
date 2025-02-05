using System;
using UnityEngine;

namespace BayatGames.SaveGamePro.Serialization.Types
{
	public abstract class SaveGameType
	{
		public abstract Type AssociatedType { get; }

		public abstract void Write(object value, ISaveGameWriter writer);

		public virtual object Read(ISaveGameReader reader)
		{
			return null;
		}

		public virtual void ReadInto(object value, ISaveGameReader reader)
		{
		}

		public static T CreateComponent<T>() where T : Component
		{
			return null;
		}

		public static Component CreateComponent(Type type)
		{
			return null;
		}
	}
}
