using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Falcon.FalconCore.Scripts.Services.GameObjs
{
	public class FGameObj : MonoBehaviour
	{
		private static FGameObj _instance;

		private bool gameStop;

		private List<IPioneerService> pioneerServices;

		private List<ITerminalService> terminalServices;

		protected List<IPioneerService> PioneerServices => null;

		protected List<ITerminalService> TerminalServices => null;

		public static FGameObj Instance => null;

		public static bool ApplicationRunning { get; private set; }

		private void Awake()
		{
		}

		public void Update()
		{
		}

		private void OnApplicationFocus(bool hasFocus)
		{
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		private void OnApplicationQuit()
		{
		}

		public T AddIfNotExist<T>() where T : MonoBehaviour
		{
			return null;
		}

		public Component AddIfNotExist(Type type)
		{
			return null;
		}

		private void CheckGameStop()
		{
		}

		private void CheckGameContinue()
		{
		}
	}
}
