using System;
using System.Collections.Generic;
using BayatGames.SaveGamePro.Serialization.Types;
using UnityEngine;

namespace BayatGames.SaveGamePro.Serialization
{
	public static class SaveGameTypeManager
	{
		private static Dictionary<Type, SaveGameType> m_Types;

		public static Dictionary<Type, SaveGameType> Types => null;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void Initialize()
		{
		}

		public static void AddType(Type type, SaveGameType saveGameType)
		{
		}

		public static void RemoveType(Type type)
		{
		}

		public static SaveGameType GetType(Type type)
		{
			return null;
		}

		public static bool HasType(Type type)
		{
			return false;
		}
	}
}
