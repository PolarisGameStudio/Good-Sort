using System.Collections.Generic;
using UnityEngine;

namespace BayatGames.SaveGamePro
{
	[AddComponentMenu("Save Game Pro/Auto Save")]
	public class SaveGameAuto : SaveGameAutoBehaviour
	{
		[SerializeField]
		protected List<Object> m_Objects;

		public virtual List<Object> Objects => null;

		public override void Save()
		{
		}

		public override void Load()
		{
		}
	}
}
