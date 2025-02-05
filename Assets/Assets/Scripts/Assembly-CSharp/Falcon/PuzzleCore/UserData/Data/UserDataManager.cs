using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Falcon.PuzzleCore.UserData.Data
{
	public class UserDataManager : PersistentSingleton<UserDataManager>
	{

		public const string ServerAccountIdKey = "server_account_id";

		private static bool loginSuccess;

		public static Action<bool> onLoginStateChange;

		private bool cheated;

		public static bool LoginSuccess => false;

		public void SetLoginState(bool state)
		{
		}

		protected override void Awake()
		{
		}

		private void OnUpdateSessionState(bool obj)
		{
		}

		private void Start()
		{
		}

		private IEnumerator WaitSetAccountID()
		{
			return null;
		}

		private void OnDataCheat()
		{
		}

		private void OnLockCheat()
		{
		}

		private void HackSuspicion()
		{
		}

		public void StartSession()
		{
		}

		private IEnumerator IEWaitSessionActive()
		{
			return null;
		}

		public void ScLoginResponse(ScLogin sc)
		{
		}

		public void UpdateAllDataFromServer(ClientData clientData)
		{
		}

		public void UpdateGameDataFromServer(ScUpdateGameData sc)
		{
		}

		public void InitToken(ScNewAccount sc)
		{
		}

		public void BindDataFromServer(ClientData clientData)
		{
		}

		public void BindReponse(SCBindDataRsp sc)
		{
		}

		public static void UpdateDataToServer(bool isincreaseSequence = true)
		{
		}

		public void ClearToken()
		{
		}

		public static void RestartGameNow()
		{
		}

		public void BinDataWithGooglePlay()
		{
		}

		public void LoginFb(string userId, string userName, string avatar_url)
		{
		}
	}
}
