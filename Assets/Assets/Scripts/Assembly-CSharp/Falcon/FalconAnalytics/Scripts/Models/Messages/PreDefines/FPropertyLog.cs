using System;
using Falcon.FalconAnalytics.Scripts.Models.Attributes;
using Falcon.FalconAnalytics.Scripts.Models.Messages.Abstracts;
using UnityEngine.Scripting;

namespace Falcon.FalconAnalytics.Scripts.Models.Messages.PreDefines
{
	[Serializable]
	public class FPropertyLog : BaseFalconLog
	{
		[FKey(Name = "pName$")]
		public string pName;

		[FKey(Name = "pValue$")]
		public string pValue;

		public int priority;

		[FKey(RemoveIfNull = true)]
		public int? currentLevel;

		public override string Event => null;

		[Preserve]
		public FPropertyLog()
		{
		}

		public FPropertyLog(string pName, string pValue, int priority, int? currentLevel = null)
		{
		}
	}
}
