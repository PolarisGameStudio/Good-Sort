using System;
using Falcon.FalconAnalytics.Scripts.Enum;
using Falcon.FalconAnalytics.Scripts.Models.Attributes;
using Falcon.FalconAnalytics.Scripts.Models.Messages.Abstracts;
using UnityEngine.Scripting;

namespace Falcon.FalconAnalytics.Scripts.Models.Messages.PreDefines
{
	[Serializable]
	public class FAdLog : BaseFalconLog
	{
		[FKey(Name = "type$")]
		public AdType type;

		[FKey(Name = "adWhere$")]
		public string adWhere;

		public int typeCount;

		[FKey(RemoveIfNull = true)]
		public string adPrecision;

		[FKey(RemoveIfNull = true)]
		public string adCountry;

		[FKey(RemoveIfNull = true)]
		public string adNetwork;

		[FKey(RemoveIfNull = true)]
		public string adMediation;

		[FKey(RemoveIfNull = true)]
		public double? adRev;

		[FKey(RemoveIfNull = true)]
		public int? currentLevel;

		public override string Event => null;

		[Preserve]
		public FAdLog()
		{
		}

		public FAdLog(AdType type, string adWhere, int? currentLevel = null, double? adLtv = null)
		{
		}

		public FAdLog(AdType type, string adWhere, string adPrecision, string adCountry, double adRev, string adNetwork, string adMediation, int? currentLevel = null, double? adLtv = null)
		{
		}
	}
}
