using System.Reflection;

namespace BayatGames.SaveGamePro.Reflection
{
	public static class PropertyInfoUtils
	{
		public static bool IsSavable(this PropertyInfo property)
		{
			return false;
		}
	}
}
