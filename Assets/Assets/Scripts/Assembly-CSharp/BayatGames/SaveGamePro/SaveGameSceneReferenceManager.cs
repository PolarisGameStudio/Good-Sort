using UnityEngine;

namespace BayatGames.SaveGamePro
{
	[DisallowMultipleComponent]
	public class SaveGameSceneReferenceManager : MonoBehaviour
	{
		private static SaveGameSceneReferenceManager current;

		public static SaveGameSceneReferenceManager Current => null;
	}
}
