using System;
using Falcon.FalconAnalytics.Scripts.Models.Messages.Abstracts;
using UnityEngine.Scripting;

namespace Falcon.FalconAnalytics.Scripts.Models.Messages.PreDefines
{
	[Serializable]
	public class FRetentionLog : BaseFalconLog
	{
		public string localDate;

		public override string Event => null;

		[Preserve]
		public FRetentionLog()
		{
		}

		public FRetentionLog(DateTime localDate)
		{
		}
	}
}
