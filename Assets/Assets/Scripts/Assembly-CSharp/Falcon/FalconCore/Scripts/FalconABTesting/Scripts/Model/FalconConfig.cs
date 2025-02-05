using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Falcon.FalconCore.Scripts.Controllers.Interfaces;
using Falcon.FalconCore.Scripts.Utils.Entities;
using Falcon.FalconCore.Scripts.Utils.FActions.Variances.Starts;
using UnityEngine.Scripting;

namespace Falcon.FalconCore.Scripts.FalconABTesting.Scripts.Model
{
	public abstract class FalconConfig
	{
		[Preserve]
		private sealed class FConfigInit : IFInit
		{

			[Preserve]
			public FConfigInit()
			{
			}

			public IEnumerator Init()
			{
				return null;
			}

			private static void UpdateFromWeb()
			{
			}
		}

		private static readonly FConcurrentDict<Type, FalconConfig> Cache;

		private static readonly object Locker;

		private static string _abTestString;

		public static ExecState UpdateFromNet { get; private set; }

		public static string RunningAbTesting => null;

		public static string AbTestingString => null;
		public static T Instance<T>() where T : FalconConfig, new()
		{
			return null;
		}

		private static T CreateInstance<T>() where T : FalconConfig, new()
		{
			return null;
		}
	}
}
