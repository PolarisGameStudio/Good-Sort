using System;
using Falcon.FalconAnalytics.Scripts.Models.Attributes;
using Falcon.FalconAnalytics.Scripts.Models.Messages.Abstracts;
using UnityEngine.Scripting;

namespace Falcon.FalconAnalytics.Scripts.Models.Messages.PreDefines
{
	[Serializable]
	public class FInAppLog : BaseFalconLog
	{
		[FKey(Name = "productId$")]
		public string productId;

		[FKey(Name = "where$")]
		public string where;

		public string isoCurrencyCode;

		public string transactionId;

		public decimal localizedPrice;

		[FKey(RemoveIfNull = true)]
		public string purchaseToken;

		[FKey(RemoveIfNull = true)]
		public int? currentLevel;

		[FKey(RemoveIfNull = true)]
		public string purchaseMethod;

		public override string Event => null;

		[Preserve]
		public FInAppLog()
		{
		}

		public FInAppLog(string productId, decimal localizedPrice, string isoCurrencyCode, string where, string transactionId, string purchaseToken = null, int? currentLevel = null, string purchaseMethod = null)
		{
		}
	}
}
