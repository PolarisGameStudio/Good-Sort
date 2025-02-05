using System.IO;

namespace BayatGames.SaveGamePro.IO
{
	public class SaveGameMemoryStorage : SaveGameStorage
	{
		protected MemoryStream m_TempStream;

		public override bool HasFileIO => false;

		public override Stream GetReadStream(SaveGameSettings settings)
		{
			return null;
		}

		public override Stream GetWriteStream(SaveGameSettings settings)
		{
			return null;
		}

		public virtual MemoryStream GetWriteStream(byte[] buffer, SaveGameSettings settings)
		{
			return null;
		}

		public override void OnSaved(SaveGameSettings settings)
		{
		}

		public override void Clear(SaveGameSettings settings)
		{
		}

		public override void Copy(string fromIdentifier, string toIdentifier, SaveGameSettings settings)
		{
		}

		public override void Delete(SaveGameSettings settings)
		{
		}

		public override bool Exists(SaveGameSettings settings)
		{
			return false;
		}

		public override FileInfo[] GetFiles(SaveGameSettings settings)
		{
			return null;
		}

		public override DirectoryInfo[] GetDirectories(SaveGameSettings settings)
		{
			return null;
		}

		public override void Move(string fromIdentifier, string toIdentifier, SaveGameSettings settings)
		{
		}
	}
}
