using BayatGames.SaveGamePro.Events;
using UnityEngine;

namespace BayatGames.SaveGamePro
{
	public abstract class SaveGameBehaviour : MonoBehaviour
	{
		[SerializeField]
		protected SaveGameSettings m_SaveSettings;

		[SerializeField]
		protected SaveEvent m_OnSaved;

		[SerializeField]
		protected LoadEvent m_OnLoaded;

		public virtual SaveGameSettings SaveSettings
		{
			get
			{
				return default(SaveGameSettings);
			}
			set
			{
			}
		}

		public virtual SaveEvent OnSaved => null;

		public virtual LoadEvent OnLoaded => null;

		public virtual void Save()
		{
		}

		public virtual void Load()
		{
		}
	}
}
