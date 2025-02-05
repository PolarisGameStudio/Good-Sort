using System;
using Falcon.FalconAnalytics.Scripts.Enum;
using Falcon.FalconAnalytics.Scripts.Models.Attributes;
using Falcon.FalconAnalytics.Scripts.Models.Messages.Abstracts;
using UnityEngine.Scripting;

namespace Falcon.FalconAnalytics.Scripts.Models.Messages.PreDefines
{
	[Serializable]
	public class FResourceLog : BaseFalconLog
	{
		[FKey(Name = "flowType$")]
		public FlowType flowType;

		[FKey(Name = "itemType$")]
		public string itemType;

		[FKey(Name = "currency$")]
		public string currency;

		public string itemId;

		public long amount;

		[FKey(RemoveIfNull = true)]
		public int? currentLevel;

		public override string Event => null;

		[Preserve]
		public FResourceLog()
		{
		}

		public FResourceLog(FlowType flowType, string itemType, string currency, string itemId, long amount, int? currentLevel = null)
		{
		}
	}
}
