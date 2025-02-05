using System.IO;

namespace BayatGames.SaveGamePro.IO
{
	public abstract class SaveGameStorage
	{
		public abstract bool HasFileIO { get; }

		public SaveGameStorage()
		{
		}

		public virtual void OnSave(SaveGameSettings settings)
		{
		}

		public virtual void OnLoad(SaveGameSettings settings)
		{
		}

		public virtual void OnSaved(SaveGameSettings settings)
		{
		}

		public virtual void OnLoaded(SaveGameSettings settings)
		{
		}

		public abstract Stream GetWriteStream(SaveGameSettings settings);

		public abstract Stream GetReadStream(SaveGameSettings settings);

		public abstract void Clear(SaveGameSettings settings);

		public abstract void Delete(SaveGameSettings settings);

		public abstract bool Exists(SaveGameSettings settings);

		public abstract FileInfo[] GetFiles(SaveGameSettings settings);

		public abstract DirectoryInfo[] GetDirectories(SaveGameSettings settings);

		public abstract void Move(string fromIdentifier, string toIdentifier, SaveGameSettings settings);

		public abstract void Copy(string fromIdentifier, string toIdentifier, SaveGameSettings settings);

		public static SaveGameStorage GetAppropriate()
		{
			return null;
		}

		public static bool IsAppropriate(SaveGameStorage storage)
		{
			return false;
		}
	}
}
