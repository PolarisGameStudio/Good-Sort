using System;
using Falcon.FalconAnalytics.Scripts.Models.Attributes;
using Falcon.FalconAnalytics.Scripts.Models.Messages.Abstracts;
using UnityEngine.Scripting;

namespace Falcon.FalconAnalytics.Scripts.Models.Messages.PreDefines
{
	[Serializable]
	public class FFunnelLog : BaseFalconLog
	{
		[FKey(Name = "funnelName$")]
		public string funnelName;

		[FKey(Name = "funnelDay$")]
		public string funnelDay;

		[FKey(Name = "priority$")]
		public int priority;

		public string action;

		[FKey(RemoveIfNull = true)]
		public int? currentLevel;

		public override string Event => null;

		[Preserve]
		public FFunnelLog()
		{
		}

		public FFunnelLog(string funnelName, string action, int priority, int? currentLevel = null)
		{
		}
	}
}
