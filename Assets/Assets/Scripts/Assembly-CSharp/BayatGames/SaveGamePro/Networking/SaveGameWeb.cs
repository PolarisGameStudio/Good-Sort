using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace BayatGames.SaveGamePro.Networking
{
	public class SaveGameWeb : SaveGameCloud
	{
	
		protected string m_SecretKey;

		protected string m_Username;

		protected string m_Password;

		protected string m_Url;

		protected bool m_CreateAccount;

		protected UnityWebRequest m_Request;

		public virtual string SecretKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual string Username
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual string Password
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual bool CreateAccount
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual string Url
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual UnityWebRequest Request => null;

		public SaveGameWeb(string url, string secretKey, string username, string password)
		{
		}

		public SaveGameWeb(string url, string secretKey, string username, string password, SaveGameSettings settings)
		{
		}

		public virtual IEnumerator GetFileUrl(string identifier)
		{
			return null;
		}

		public virtual IEnumerator GetFileUrl(string identifier, SaveGameSettings settings)
		{
			return null;
		}

		public virtual IEnumerator UploadFile(string identifier, string uploadIdentifier)
		{
			return null;
		}

		public virtual IEnumerator UploadFile(string identifier, string uploadIdentifier, SaveGameSettings settings)
		{
			return null;
		}

		public virtual IEnumerator DownloadFile(string identifier, string downloadIdentifier)
		{
			return null;
		}

		public virtual IEnumerator DownloadFile(string identifier, string downloadIdentifier, SaveGameSettings settings)
		{
			return null;
		}

		public override IEnumerator Save(string identifier, object value, SaveGameSettings settings)
		{
			return null;
		}

		public override IEnumerator Download(string identifier, SaveGameSettings settings)
		{
			return null;
		}

		public override object Load(Type type, object defaultValue, SaveGameSettings settings)
		{
			return null;
		}

		public override void LoadInto(object value, SaveGameSettings settings)
		{
		}

		public override IEnumerator Clear(SaveGameSettings settings)
		{
			return null;
		}

		public override IEnumerator Delete(string identifier, SaveGameSettings settings)
		{
			return null;
		}

		public virtual Dictionary<string, string> CreateRequestForm(string action, SaveGameSettings settings)
		{
			return null;
		}

		public virtual Dictionary<string, string> CreateRequestForm(string action, string identifier, SaveGameSettings settings)
		{
			return null;
		}

		public virtual Dictionary<string, string> CreateRequestForm(string action, byte[] data, SaveGameSettings settings)
		{
			return null;
		}

		public virtual Dictionary<string, string> CreateRequestForm(string action, string identifier, byte[] data, SaveGameSettings settings)
		{
			return null;
		}
	}
}
