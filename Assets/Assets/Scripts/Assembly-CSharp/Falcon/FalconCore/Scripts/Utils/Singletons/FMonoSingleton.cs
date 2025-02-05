using UnityEngine;

namespace Falcon.FalconCore.Scripts.Utils.Singletons
{
	public abstract class FMonoSingleton<T> : MonoBehaviour where T : FMonoSingleton<T>, new()
	{
		private static T _instance;

		public static T Instance
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		protected virtual void Awake()
		{
		}
	}
}
