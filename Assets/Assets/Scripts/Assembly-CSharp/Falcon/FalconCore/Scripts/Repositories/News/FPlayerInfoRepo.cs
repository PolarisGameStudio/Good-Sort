using System;
using System.Collections.Generic;
using Falcon.FalconAnalytics.Scripts.Enum;
using Falcon.FalconCore.Scripts.Utils.Entities;

namespace Falcon.FalconCore.Scripts.Repositories.News
{
	public static class FPlayerInfoRepo
	{
		public static class InApp
		{
			private const string InAppLtvKey = "Analytic_SDK_Data_In_App_Ltv";

			private const string InAppCountKey = "Analytic_SDK_Data_In_App_Count";

			private const string FirstInAppLvKey = "Analytic_SDK_Data_First_In_App_Lv";

			private const string FirstInAppDateKey = "Analytic_SDK_Data_First_In_App_Day";

			private static int _inAppCount;

			private static int? _firstInAppLv;

			private static DateTime? _firstInAppDate;

			private static readonly Dictionary<string, InAppData> InAppData;

			public static InAppData InAppLtv => null;

			public static int InAppCount
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public static int? FirstInAppLv
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public static DateTime? FirstInAppDate
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public static string FirstInAppDateStr => null;

			public static void Update(decimal amount, string isoCountryCode)
			{
			}
		}

		public static class Ad
		{
			private const string AdLtvKey = "Analytic_SDK_Data_Ad_Ltv";

			private static readonly FConcurrentDict<AdType, int> Cache;

			private static double? _adLtv;

			public static double? AdLtv
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public static int AdCountOf(AdType adType)
			{
				return 0;
			}

			public static void SetAdCountOf(AdType adType, int value)
			{
			}

			public static int IncrementAdCount(AdType adType)
			{
				return 0;
			}

			private static string KeyOf(AdType adType)
			{
				return null;
			}
		}

		public static class SelfDefine
		{
			public static Dictionary<string, object> Properties
			{
				get
				{
					return null;
				}
				private set
				{
				}
			}

			public static void AddProperty(string name, string value)
			{
			}

			public static void AddProperties(Dictionary<string, object> properties)
			{
			}

			public static void RemoveProperty(string name)
			{
			}

			public static void RemoveProperties(IEnumerable<string> names)
			{
			}

			public static void Clear()
			{
			}
		}

		private const string AnalyticDataPrefix = "Analytic_SDK_Data_";

		private const string AccountIDKey = "Analytic_SDK_Data_Account_ID_Key";

		private const string FirstLoginMillisKey = "CREATE_DATE";

		private const string ActiveDaysKey = "Analytic_SDK_Data_Active_Days";

		private const string MaxLevelKey = "Analytic_SDK_Data_Max_Level";

		private const string SessionIDKey = "Session_Count";

		private const string InstallVersionKey = "Analytic_SDK_Data_Install_Version";

		private const string SelfDefinePropertiesKey = "Analytic_SDK_Data_Self_Define_Properties";

		private static string _accountId;

		private static int? _maxPassedLevel;

		private static int? _sessionId;

		private static string _installVersion;

		private static long? _firstLogInMillis;

		private static int? _activeDays;

		private static DateTime? _firstLogInDateTime;

		public static DateTime FirstLogInDateTime => default(DateTime);

		public static long FirstLogInMillis
		{
			get
			{
				return 0L;
			}
			private set
			{
			}
		}

		public static DateTime FirstLoginDate => default(DateTime);

		public static int ActiveDays
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static string AccountID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string AbTestingVariable => null;

		public static string AbTestingValue => null;

		public static int MaxPassedLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int SessionId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static string InstallVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
