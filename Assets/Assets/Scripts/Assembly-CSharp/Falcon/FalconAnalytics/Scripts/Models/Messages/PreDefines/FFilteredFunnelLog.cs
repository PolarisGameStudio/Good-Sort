using System;
using Falcon.FalconAnalytics.Scripts.Models.Attributes;
using Falcon.FalconAnalytics.Scripts.Models.Messages.Abstracts;
using UnityEngine.Scripting;

namespace Falcon.FalconAnalytics.Scripts.Models.Messages.PreDefines
{
	[Serializable]
	public class FFilteredFunnelLog : BaseFalconLog
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

		[FKey(Ignore = true)]
		public bool logValid;

		public override string Event => null;

		[Preserve]
		public FFilteredFunnelLog()
		{
		}

		public FFilteredFunnelLog(string funnelName, string action, int priority, int? currentLevel = null)
		{
		}

		public override void Send()
		{
		}
	}
}
