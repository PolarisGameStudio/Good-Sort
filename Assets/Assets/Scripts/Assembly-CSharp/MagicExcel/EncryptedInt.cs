using System;
using CodeStage.AntiCheat.ObscuredTypes;
using Newtonsoft.Json;
using UnityEngine;

namespace MagicExcel
{
	[Serializable]
	[JsonConverter(typeof(EncryptedTypeJsonConverter))]
	public struct EncryptedInt : IEncryptedType
	{
		private const int KEY = 82380971;

		[SerializeField]
		private int encryptedValue;

		public EncryptedInt(int value)
		{
			encryptedValue = 0;
		}

		public object Decrypt()
		{
			return null;
		}

		public static int Decrypt(int encryptedValue)
		{
			return 0;
		}

		public static implicit operator int(EncryptedInt value)
		{
			return 0;
		}

		public static implicit operator ObscuredInt(EncryptedInt value)
		{
			return default(ObscuredInt);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
