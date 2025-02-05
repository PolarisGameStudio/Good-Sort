using System.Security.Cryptography;
using System.Text;

namespace MagicExcel
{
	public static class Security
	{
		private static readonly byte[] key;

		private static readonly byte[] vector;

		private static readonly ICryptoTransform encryptor;

		private static readonly ICryptoTransform decryptor;

		private static readonly UTF8Encoding encoder;

		static Security()
		{
		}

		public static string Encrypt(this string unencrypted)
		{
			return null;
		}

		public static string Decrypt(this string encrypted)
		{
			return null;
		}

		public static byte[] Encrypt(byte[] buffer)
		{
			return null;
		}

		public static byte[] Decrypt(byte[] buffer)
		{
			return null;
		}

		private static byte[] Transform(byte[] buffer, ICryptoTransform transform)
		{
			return null;
		}
	}
}
