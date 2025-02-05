using System;
using System.Collections.Generic;
using System.Diagnostics;
using Falcon.FalconAnalytics.Scripts.Models.Attributes;

namespace Falcon.FalconAnalytics.Scripts.Models.Messages.Abstracts
{
	[Serializable]
	public abstract class BaseFalconLog : PlainLog
	{
		[FKey(Name = "appVersion$")]
		public string appVersion;

		[FKey(Name = "abTestingValue$", RemoveIfNull = true)]
		public string abTestingValue;

		[FKey(Name = "abTestingVariable$", RemoveIfNull = true)]
		public string abTestingVariable;

		[FKey(Name = "retentionDay$")]
		public int retentionDay;

		[FKey(Name = "level$")]
		public int level;

		public int sessionId;

		public string sessionUid;

		public int inAppCount;

		public int adCount;

		public int interAdCount;

		public int rewardAdCount;

		public string uuid;

		public decimal inAppLtv;

		public decimal maxInApp;

		public string ltvIsoCurrencyCode;

		[FKey(RemoveIfNull = true)]
		public double? adLtv;

		public long sessionsSum;

		public int activeDays;

		public int apiId;

		[Conditional("ENABLE_LOG")]
		protected void LogParams(params object[] parameters)
		{
		}

		public override Dictionary<string, object> ToDictionary()
		{
			return null;
		}

		private int GetApiId()
		{
			return 0;
		}

		protected int CheckNumberNonNegative(int i, string fieldName)
		{
			return 0;
		}

		protected long CheckNumberNonNegative(long i, string fieldName)
		{
			return 0L;
		}

		protected float CheckNumberNonNegative(float i, string fieldName)
		{
			return 0f;
		}

		protected double CheckNumberNonNegative(double i, string fieldName)
		{
			return 0.0;
		}

		protected decimal CheckNumberNonNegative(decimal i, string fieldName)
		{
			return default(decimal);
		}
	}
}
