using System;
using Falcon.FalconAnalytics.Scripts.Models.Attributes;
using Falcon.FalconAnalytics.Scripts.Models.Messages.Abstracts;
using UnityEngine.Scripting;

namespace Falcon.FalconAnalytics.Scripts.Models.Messages.PreDefines
{
	[Serializable]
	public class FSessionLog : BaseFalconLog
	{
		[FKey(Name = "gameMode$")]
		public string gameMode;

		public int sessionTime;

		public long modeTotalTime;

		[FKey(RemoveIfNull = true)]
		public int? currentLevel;

		public override string Event => null;

		[Preserve]
		public FSessionLog()
		{
		}

		public FSessionLog(string gameMode, TimeSpan sessionTime, int? currentLevel = null)
		{
		}
	}
}
