using System;
using Newtonsoft.Json;
using UnityEngine;

namespace MagicExcel
{
	[Serializable]
	[JsonConverter(typeof(EncryptedTypeJsonConverter))]
	public struct EncryptedLong : IEncryptedType
	{
		private const long KEY = 82380971L;

		[SerializeField]
		private long encryptedValue;

		public EncryptedLong(long value)
		{
			encryptedValue = 0L;
		}

		public object Decrypt()
		{
			return null;
		}

		public static long Decrypt(long encryptedValue)
		{
			return 0L;
		}

		public static implicit operator long(EncryptedLong value)
		{
			return 0L;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
