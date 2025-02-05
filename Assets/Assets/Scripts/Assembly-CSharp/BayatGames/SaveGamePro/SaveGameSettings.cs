using System;
using System.Security.Cryptography;
using System.Text;
using BayatGames.SaveGamePro.IO;
using BayatGames.SaveGamePro.Serialization;
using UnityEngine;

namespace BayatGames.SaveGamePro
{
	[Serializable]
	public struct SaveGameSettings
	{
		public const int EncryptionIvSize = 16;

		public const int EncryptionKeySize = 16;

		public const int EncryptionPwIterations = 100;

		private static string m_DefaultBasePath;

		private static ISaveGameFormatter m_DefaultFormatter;

		private static SaveGameStorage m_DefaultStorage;

		private static Encoding m_DefaultEncoding;

		[SerializeField]
		private string m_Identifier;

		[SerializeField]
		private string m_BasePath;

		private ISaveGameFormatter m_Formatter;

		private SaveGameStorage m_Storage;

		private Encoding m_Encoding;

		private static bool m_DefaultEncrypt;

		private static string m_DefaultEncryptionPassword;

		private static int m_DefaultEncryptionIterations;

		private static string m_DefaultEncryptionHash;

		private static string m_DefaultEncryptionSalt;

		private static string m_DefaultEncryptionVector;

		[SerializeField]
		private bool m_Encrypt;

		[SerializeField]
		private string m_EncryptionPassword;

		[SerializeField]
		private int m_EncryptionIterations;

		[SerializeField]
		private string m_EncryptionHash;

		[SerializeField]
		private string m_EncryptionSalt;

		[SerializeField]
		private string m_EncryptionVector;

		private byte[] m_EncryptionIV;

		public static string DefaultBasePath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool DefaultEncrypt
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static string DefaultEncryptionPassword
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static int DefaultEncryptionIterations
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static string DefaultEncryptionHash
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string DefaultEncryptionSalt
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string DefaultEncryptionVector
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static ISaveGameFormatter DefaultFormatter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static SaveGameStorage DefaultStorage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static Encoding DefaultEncoding
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Identifier
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string BasePath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Encrypt
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string EncryptionPassword
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("Save Game Pro: This property will be removed in the next version.")]
		public int EncryptionIterations
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[Obsolete("Save Game Pro: This property will be removed in the next version.")]
		public string EncryptionHash
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("Save Game Pro: This property will be removed in the next version.")]
		public string EncryptionSalt
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("Save Game Pro: This property has been renamed to EnncryptionIV and the type changed from string to byte[], it'll be removed in the next version.")]
		public string EncryptionVector
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public byte[] EncryptionIV
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ISaveGameFormatter Formatter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SaveGameStorage Storage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Encoding Encoding
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ICryptoTransform Encryptor => null;

		public ICryptoTransform Decryptor => null;

		public SaveGameSettings(string identifier)
		{
			m_Identifier = null;
			m_BasePath = null;
			m_Formatter = null;
			m_Storage = null;
			m_Encoding = null;
			m_Encrypt = false;
			m_EncryptionPassword = null;
			m_EncryptionIterations = 0;
			m_EncryptionHash = null;
			m_EncryptionSalt = null;
			m_EncryptionVector = null;
			m_EncryptionIV = null;
		}

		public SaveGameSettings(string identifier, string basePath)
		{
			m_Identifier = null;
			m_BasePath = null;
			m_Formatter = null;
			m_Storage = null;
			m_Encoding = null;
			m_Encrypt = false;
			m_EncryptionPassword = null;
			m_EncryptionIterations = 0;
			m_EncryptionHash = null;
			m_EncryptionSalt = null;
			m_EncryptionVector = null;
			m_EncryptionIV = null;
		}

		public SaveGameSettings(string identifier, ISaveGameFormatter formatter)
		{
			m_Identifier = null;
			m_BasePath = null;
			m_Formatter = null;
			m_Storage = null;
			m_Encoding = null;
			m_Encrypt = false;
			m_EncryptionPassword = null;
			m_EncryptionIterations = 0;
			m_EncryptionHash = null;
			m_EncryptionSalt = null;
			m_EncryptionVector = null;
			m_EncryptionIV = null;
		}

		public SaveGameSettings(string identifier, SaveGameStorage storage)
		{
			m_Identifier = null;
			m_BasePath = null;
			m_Formatter = null;
			m_Storage = null;
			m_Encoding = null;
			m_Encrypt = false;
			m_EncryptionPassword = null;
			m_EncryptionIterations = 0;
			m_EncryptionHash = null;
			m_EncryptionSalt = null;
			m_EncryptionVector = null;
			m_EncryptionIV = null;
		}

		public SaveGameSettings(string identifier, string basePath, ISaveGameFormatter formatter, SaveGameStorage storage)
		{
			m_Identifier = null;
			m_BasePath = null;
			m_Formatter = null;
			m_Storage = null;
			m_Encoding = null;
			m_Encrypt = false;
			m_EncryptionPassword = null;
			m_EncryptionIterations = 0;
			m_EncryptionHash = null;
			m_EncryptionSalt = null;
			m_EncryptionVector = null;
			m_EncryptionIV = null;
		}
	}
}
