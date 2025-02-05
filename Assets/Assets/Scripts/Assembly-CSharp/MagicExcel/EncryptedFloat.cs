using System;
using CodeStage.AntiCheat.ObscuredTypes;
using Newtonsoft.Json;
using UnityEngine;

namespace MagicExcel
{
	[Serializable]
	[JsonConverter(typeof(EncryptedTypeJsonConverter))]
	public struct EncryptedFloat : IEncryptedType
	{
		private const int KEY = 82380971;

		[SerializeField]
		private int encryptedValue;

		public EncryptedFloat(float value)
		{
			encryptedValue = 0;
		}

		public object Decrypt()
		{
			return null;
		}

		public static float Decrypt(int encryptedValue)
		{
			return 0f;
		}

		public static implicit operator float(EncryptedFloat value)
		{
			return 0f;
		}

		public static implicit operator ObscuredFloat(EncryptedFloat value)
		{
			return default(ObscuredFloat);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
