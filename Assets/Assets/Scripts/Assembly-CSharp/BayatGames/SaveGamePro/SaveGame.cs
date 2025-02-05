using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace BayatGames.SaveGamePro
{
	public static class SaveGame
	{
		public delegate void SaveEventHandler(string identifier, object value, SaveGameSettings settings);

		public delegate void LoadEventHandler(string identifier, object result, Type type, object defaultValue, SaveGameSettings settings);

		public delegate void LoadIntoEventHandler(string identifier, object value, SaveGameSettings settings);

		public delegate void DeleteEventHandler(string identifier, SaveGameSettings settings);

		public delegate void MoveEventHandler(string fromIdentifier, string toIdentifier, SaveGameSettings settings);

		public delegate void ClearEventHandler(SaveGameSettings settings);

		public static readonly string PersistentDataPath;

		public static readonly Thread MainThread;

		public static readonly Version Version;

		public static readonly string MetaDataExtension;

		private static SaveGameSettings m_DefaultSettings;

		public static SaveGameSettings DefaultSettings
		{
			get
			{
				return default(SaveGameSettings);
			}
			set
			{
			}
		}

		public static bool IsFileIOSupported => false;

		public static bool IsWindowsStore => false;


		public static void SaveAllBehaviours()
		{
		}

		public static void LoadAllBehaviours()
		{
		}

		public static Task SaveAsync<T>(string identifier, T value)
		{
			return null;
		}

		public static void Save<T>(string identifier, T value)
		{
		}

		public static Task SaveAsync(string identifier, object value)
		{
			return null;
		}

		public static void Save(string identifier, object value)
		{
		}

		public static Task SaveAsync<T>(string identifier, T value, SaveGameSettings settings)
		{
			return null;
		}

		public static void Save<T>(string identifier, T value, SaveGameSettings settings)
		{
		}

		public static Task SaveAsync(string identifier, object value, SaveGameSettings settings)
		{
			return null;
		}

		public static void Save(string identifier, object value, SaveGameSettings settings)
		{
		}

		public static void SaveRaw(string identifier, byte[] data)
		{
		}

		public static void SaveRaw(string identifier, byte[] value, SaveGameSettings settings)
		{
		}

		public static Task<T> LoadAsync<T>(string identifier)
		{
			return null;
		}

		public static T Load<T>(string identifier)
		{
			return default(T);
		}

		public static Task<object> LoadAsync(string identifier, Type type)
		{
			return null;
		}

		public static object Load(string identifier, Type type)
		{
			return null;
		}

		public static Task<T> LoadAsync<T>(string identifier, T defaultValue)
		{
			return null;
		}

		public static T Load<T>(string identifier, T defaultValue)
		{
			return default(T);
		}

		public static Task<object> LoadAsync(string identifier, Type type, object defaultValue)
		{
			return null;
		}

		public static object Load(string identifier, Type type, object defaultValue)
		{
			return null;
		}

		public static Task<T> LoadAsync<T>(string identifier, T defaultValue, SaveGameSettings settings)
		{
			return null;
		}

		public static T Load<T>(string identifier, T defaultValue, SaveGameSettings settings)
		{
			return default(T);
		}

		public static Task<object> LoadAsync(string identifier, Type type, object defaultValue, SaveGameSettings settings)
		{
			return null;
		}

		public static object Load(string identifier, Type type, object defaultValue, SaveGameSettings settings)
		{
			return null;
		}

		public static byte[] LoadRaw(string identifier)
		{
			return null;
		}

		public static byte[] LoadRaw(string identifier, SaveGameSettings settings)
		{
			return null;
		}

		public static Task LoadIntoAsync<T>(string identifier, T value)
		{
			return null;
		}

		public static void LoadInto<T>(string identifier, T value)
		{
		}

		public static Task LoadIntoAsync(string identifier, object value)
		{
			return null;
		}

		public static void LoadInto(string identifier, object value)
		{
		}

		public static Task LoadIntoAsync<T>(string identifier, T value, SaveGameSettings settings)
		{
			return null;
		}

		public static void LoadInto<T>(string identifier, T value, SaveGameSettings settings)
		{
		}

		public static Task LoadIntoAsync(string identifier, object value, SaveGameSettings settings)
		{
			return null;
		}

		public static void LoadInto(string identifier, object value, SaveGameSettings settings)
		{
		}

		public static void Clear()
		{
		}

		public static void Clear(SaveGameSettings settings)
		{
		}

		public static void Delete(string identifier)
		{
		}

		public static void Delete(string identifier, SaveGameSettings settings)
		{
		}

		public static void Copy(string fromIdentifier, string toIdentifier)
		{
		}

		public static void Copy(string fromIdentifier, string toIdentifier, SaveGameSettings settings)
		{
		}

		public static void Move(string fromIdenifier, string toIdentifier)
		{
		}

		public static void Move(string fromIdentifier, string toIdentifier, SaveGameSettings settings)
		{
		}

		public static bool Exists(string identifier)
		{
			return false;
		}

		public static bool Exists(string identifier, SaveGameSettings settings)
		{
			return false;
		}

		public static FileInfo[] GetFiles()
		{
			return null;
		}

		public static FileInfo[] GetFiles(string identifier)
		{
			return null;
		}

		public static FileInfo[] GetFiles(string identifier, SaveGameSettings settings)
		{
			return null;
		}

		public static DirectoryInfo[] GetDirectories()
		{
			return null;
		}

		public static DirectoryInfo[] GetDirectories(string identifier)
		{
			return null;
		}

		public static DirectoryInfo[] GetDirectories(string identifier, SaveGameSettings settings)
		{
			return null;
		}

		public static Task SaveImageAsync(string identifier, Texture2D texture)
		{
			return null;
		}

		public static void SaveImage(string identifier, Texture2D texture)
		{
		}

		public static Task SaveImageAsync(string identifier, Texture2D texture, SaveGameSettings settings)
		{
			return null;
		}

		public static void SaveImage(string identifier, Texture2D texture, SaveGameSettings settings)
		{
		}

		public static Task<Texture2D> LoadImageAsync(string identifier)
		{
			return null;
		}

		public static Texture2D LoadImage(string identifier)
		{
			return null;
		}

		public static Task<Texture2D> LoadImageAsync(string identifier, SaveGameSettings settings)
		{
			return null;
		}

		public static Texture2D LoadImage(string identifier, SaveGameSettings settings)
		{
			return null;
		}

		public static string GetAbsolutePath(string identifier)
		{
			return null;
		}

		public static string GetAbsolutePath(string identifier, SaveGameSettings settings)
		{
			return null;
		}
	}
}
