using System;
using System.Collections.Generic;
using Falcon.FalconCore.Scripts.Services.GameObjs;
using Falcon.FalconCore.Scripts.Utils;
using Falcon.FalconCore.Scripts.Utils.Entities;
using Falcon.FalconCore.Scripts.Utils.Singletons;
using UnityEngine.Scripting;

namespace Falcon.FalconCore.Scripts.Repositories
{
	public class FDataPool : FSingleton<FDataPool>, ITerminalService
	{
		public static readonly string DataFile;

		private readonly FConcurrentDict<string, string> cache;

		private readonly FFile file;

		[Preserve]
		public FDataPool()
		{
		}

		public void OnPostStop()
		{
		}

		public T GetOrDefault<T>(string key, T defaultValue)
		{
			return default(T);
		}

		public T GetOrSet<T>(string key, T valueIfNotExist)
		{
			return default(T);
		}

		public bool HasKey(string key)
		{
			return false;
		}

		public void ComputeIfPresent<T>(string key, Action<T> ifPresent)
		{
		}

		public KeyValuePair<bool, T> ComputeIfPresent<T>(string key, Func<T, T> ifPresent)
		{
			return default(KeyValuePair<bool, T>);
		}

		public void ComputeIfAbsent(string key, Action computation)
		{
		}

		public KeyValuePair<bool, T> ComputeIfAbsent<T>(string key, Func<T> ifAbsent)
		{
			return default(KeyValuePair<bool, T>);
		}

		public T Compute<T>(string key, Func<bool, T, T> function)
		{
			return default(T);
		}

		public void Save<T>(string key, T value)
		{
		}

		public void Delete(string key)
		{
		}

		private void SaveData()
		{
		}
	}
}
