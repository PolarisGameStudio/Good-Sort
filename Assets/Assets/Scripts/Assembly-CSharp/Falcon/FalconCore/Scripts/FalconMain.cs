using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Falcon.FalconCore.Scripts.Utils.Entities;
using UnityEngine;

namespace Falcon.FalconCore.Scripts
{
	public class FalconMain : MonoBehaviour
	{
	

		public static ExecState InitState { get; private set; }

		public static bool InitComplete => false;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		public static void Init()
		{
		}

		private static IEnumerator InitIEnumerator()
		{
			return null;
		}
	}
}
