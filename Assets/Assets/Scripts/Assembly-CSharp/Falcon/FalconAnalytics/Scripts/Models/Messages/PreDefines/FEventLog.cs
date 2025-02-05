using System;
using System.Collections.Generic;
using Falcon.FalconAnalytics.Scripts.Models.Attributes;
using Falcon.FalconAnalytics.Scripts.Models.Messages.Abstracts;
using UnityEngine.Scripting;

namespace Falcon.FalconAnalytics.Scripts.Models.Messages.PreDefines
{
	[Serializable]
	public class FEventLog : BaseFalconLog
	{
		[FKey(Name = "eventName$")]
		public string eventName;

		public string paramsStr;

		[FKey(RemoveIfNull = true)]
		public int? currentLevel;

		public override string Event => null;

		[Preserve]
		public FEventLog()
		{
		}

		public FEventLog(string eventName, Dictionary<string, object> param = null, int? currentLevel = null)
		{
		}
	}
}
