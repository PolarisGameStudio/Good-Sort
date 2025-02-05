using System;
using System.Collections.Generic;
using System.Reflection;

namespace BayatGames.SaveGamePro.Reflection
{
	public static class TypeUtils
	{
		public const BindingFlags SavableBindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

		public static bool IsSavable(this Type type)
		{
			return false;
		}

		public static FieldInfo GetSavableField(this Type type, string name)
		{
			return null;
		}

		public static PropertyInfo GetSavableProperty(this Type type, string name)
		{
			return null;
		}

		public static List<FieldInfo> GetSavableFields(this Type type)
		{
			return null;
		}

		public static List<PropertyInfo> GetSavableProperties(this Type type)
		{
			return null;
		}

		public static string GetFriendlyName(this Type type)
		{
			return null;
		}

		public static object GetDefault(this Type type)
		{
			return null;
		}

		public static bool IsSubclassOf<T>(this Type type)
		{
			return false;
		}

		public static bool IsValueType(this Type type)
		{
			return false;
		}

		public static object CreateInstance(this Type type)
		{
			return null;
		}

		public static Type GetNullableType(this Type type)
		{
			return null;
		}
	}
}
