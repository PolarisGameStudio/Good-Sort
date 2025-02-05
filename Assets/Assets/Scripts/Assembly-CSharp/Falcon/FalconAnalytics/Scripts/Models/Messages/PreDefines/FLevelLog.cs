using System;
using Falcon.FalconAnalytics.Scripts.Enum;
using Falcon.FalconAnalytics.Scripts.Models.Attributes;
using Falcon.FalconAnalytics.Scripts.Models.Messages.Abstracts;
using UnityEngine.Scripting;

namespace Falcon.FalconAnalytics.Scripts.Models.Messages.PreDefines
{
	[Serializable]
	public class FLevelLog : BaseFalconLog
	{
		[FKey(Name = "currentLevel$")]
		public int currentLevel;

		[FKey(Name = "difficulty$")]
		public string difficulty;

		[FKey(Name = "status$")]
		public LevelStatus status;

		public int duration;

		public int failCount;

		public int playCount;

		[FKey(RemoveIfNull = true)]
		public int? wave;

		protected virtual string LevelId => null;

		public override string Event => null;

		[Preserve]
		public FLevelLog()
		{
		}

		public FLevelLog(int currentLevel, string difficulty, LevelStatus status, TimeSpan duration, int? wave = null)
		{
		}

		private void GetRightStatus()
		{
		}

		private void SetCounting()
		{
		}

		public override void Send()
		{
		}
	}
}
