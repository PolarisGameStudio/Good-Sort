using System;
using Newtonsoft.Json;
using UnityEngine;

namespace MagicExcel
{
	[Serializable]
	[JsonConverter(typeof(EncryptedTypeJsonConverter))]
	public struct EncryptedDouble : IEncryptedType
	{
		private const long KEY = 82380971L;

		[SerializeField]
		private long encryptedValue;

		public EncryptedDouble(double value)
		{
			encryptedValue = 0L;
		}

		public object Decrypt()
		{
			return null;
		}

		public static double Decrypt(long encryptedValue)
		{
			return 0.0;
		}

		public static implicit operator double(EncryptedDouble value)
		{
			return 0.0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
