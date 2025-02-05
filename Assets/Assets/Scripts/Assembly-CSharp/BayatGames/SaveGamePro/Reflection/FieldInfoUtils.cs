using System.Reflection;

namespace BayatGames.SaveGamePro.Reflection
{
	public static class FieldInfoUtils
	{
		public static bool IsSavable(this FieldInfo field)
		{
			return false;
		}

		public static bool IsBackingField(this FieldInfo field)
		{
			return false;
		}
	}
}
