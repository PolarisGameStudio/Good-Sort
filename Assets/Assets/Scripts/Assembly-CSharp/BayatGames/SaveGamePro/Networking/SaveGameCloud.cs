using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace BayatGames.SaveGamePro.Networking
{
	public abstract class SaveGameCloud
	{
	
		protected SaveGameSettings m_Settings;

		public virtual SaveGameSettings Settings
		{
			get
			{
				return default(SaveGameSettings);
			}
			set
			{
			}
		}

		public SaveGameCloud()
		{
		}

		public SaveGameCloud(SaveGameSettings settings)
		{
		}

		public virtual Task SaveAsync<T>(string identifier, T value)
		{
			return null;
		}

		public virtual IEnumerator Save<T>(string identifier, T value)
		{
			return null;
		}

		public virtual Task SaveAsync(string identifier, object value)
		{
			return null;
		}

		public virtual IEnumerator Save(string identifier, object value)
		{
			return null;
		}

		public virtual Task SaveAsync<T>(string identifier, T value, SaveGameSettings settings)
		{
			return null;
		}

		public virtual IEnumerator Save<T>(string identifier, T value, SaveGameSettings settings)
		{
			return null;
		}

		public virtual Task SaveAsync(string identifier, object value, SaveGameSettings settings)
		{
			return null;
		}

		public abstract IEnumerator Save(string identifier, object value, SaveGameSettings settings);

		public virtual Task DownloadAsync(string identifier)
		{
			return null;
		}

		public virtual IEnumerator Download(string identifier)
		{
			return null;
		}

		public virtual Task DownloadAsync(string identifier, SaveGameSettings settings)
		{
			return null;
		}

		public abstract IEnumerator Download(string identifier, SaveGameSettings settings);

		public virtual T Load<T>()
		{
			return default(T);
		}

		public virtual object Load(Type type)
		{
			return null;
		}

		public virtual T Load<T>(T defaultValue)
		{
			return default(T);
		}

		public virtual object Load(Type type, object defaultValue)
		{
			return null;
		}

		public virtual T Load<T>(SaveGameSettings settings)
		{
			return default(T);
		}

		public virtual object Load(Type type, SaveGameSettings settings)
		{
			return null;
		}

		public virtual T Load<T>(T defaultValue, SaveGameSettings settings)
		{
			return default(T);
		}

		public abstract object Load(Type type, object defaultValue, SaveGameSettings settings);

		public virtual void LoadInto<T>(T value)
		{
		}

		public virtual void LoadInto(object value)
		{
		}

		public virtual void LoadInto<T>(T value, SaveGameSettings settings)
		{
		}

		public abstract void LoadInto(object value, SaveGameSettings settings);

		public virtual Task ClearAsync()
		{
			return null;
		}

		public virtual IEnumerator Clear()
		{
			return null;
		}

		public virtual Task ClearAsync(SaveGameSettings settings)
		{
			return null;
		}

		public abstract IEnumerator Clear(SaveGameSettings settings);

		public virtual Task DeleteAsync(string identifier)
		{
			return null;
		}

		public virtual IEnumerator Delete(string identifier)
		{
			return null;
		}

		public virtual Task DeleteAsync(string identifier, SaveGameSettings settings)
		{
			return null;
		}

		public abstract IEnumerator Delete(string identifier, SaveGameSettings settings);
	}
}
