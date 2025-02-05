using System;
using System.Collections.Generic;
using UnityEngine;

namespace Ugi.PlayInstallReferrerPlugin
{
	public class PlayInstallReferrerAndroid
	{
		private class InstallReferrerStateListener : AndroidJavaProxy
		{
			private Action<PlayInstallReferrerDetails> callback;

			public InstallReferrerStateListener(Action<PlayInstallReferrerDetails> pCallback)
				: base((string)null)
			{
			}

			public void onInstallReferrerSetupFinished(int responseCode)
			{
			}

			public void onInstallReferrerServiceDisconnected()
			{
			}
		}

		private static InstallReferrerStateListener installReferrerStateProxy;

		private static AndroidJavaObject ajoInstallReferrerClient;

		private static Dictionary<int, string> installReferrerResponseCodes;

		public static void GetInstallReferrerInfo(Action<PlayInstallReferrerDetails> callback)
		{
		}

		private static AndroidJavaObject GetInstallReferrerClient()
		{
			return null;
		}
	}
}
