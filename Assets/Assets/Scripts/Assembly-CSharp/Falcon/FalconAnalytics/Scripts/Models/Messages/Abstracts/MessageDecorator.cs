using System.Collections.Generic;

namespace Falcon.FalconAnalytics.Scripts.Models.Messages.Abstracts
{
	public static class MessageDecorator
	{
		public static Dictionary<TK, TV> Put<TK, TV>(this Dictionary<TK, TV> dict, TK key, TV value)
		{
			return null;
		}

		public static Dictionary<TK, TV> PutIfNotNull<TK, TV>(this Dictionary<TK, TV> dict, TK key, TV value)
		{
			return null;
		}

		public static Dictionary<TK, TV> PutIfAbsent<TK, TV>(this Dictionary<TK, TV> dict, TK key, TV value)
		{
			return null;
		}

		public static Dictionary<TK, TV> PutIfAbsentAndNotNull<TK, TV>(this Dictionary<TK, TV> dict, TK key, TV value)
		{
			return null;
		}

		public static string AsSortKey(this string fieldName)
		{
			return null;
		}

		public static string AsDistKey(this string fieldName)
		{
			return null;
		}
	}
}
