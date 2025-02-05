using System;

namespace BayatGames.SaveGamePro.Serialization.Types
{
	public class SaveGameType_Quaternion : SaveGameType
	{
		public override Type AssociatedType => null;

		public override void Write(object value, ISaveGameWriter writer)
		{
		}

		public override object Read(ISaveGameReader reader)
		{
			return null;
		}

		public override void ReadInto(object value, ISaveGameReader reader)
		{
		}
	}
}
