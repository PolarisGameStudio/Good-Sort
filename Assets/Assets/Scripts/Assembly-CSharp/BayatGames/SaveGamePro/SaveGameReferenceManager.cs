using System;
using System.Collections.Generic;
using UnityEngine;

namespace BayatGames.SaveGamePro
{
	public class SaveGameReferenceManager : MonoBehaviour
	{
		private static SaveGameReferenceManager current;

		[SerializeField]
		protected List<string> guids;

		[SerializeField]
		protected List<UnityEngine.Object> sceneDependencies;

		public static SaveGameReferenceManager Current => null;

		public List<string> Guids => null;

		public List<UnityEngine.Object> SceneDependencies => null;

		public UnityEngine.Object Get(string guid)
		{
			return null;
		}

		public string Get(UnityEngine.Object obj)
		{
			return null;
		}

		public void Add(UnityEngine.Object obj)
		{
		}

		public static Guid GetNewGuid()
		{
			return default(Guid);
		}
	}
}
