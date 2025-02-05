using System;
using Falcon.FalconAnalytics.Scripts.Models.Attributes;
using Falcon.FalconAnalytics.Scripts.Models.Messages.Abstracts;
using UnityEngine.Scripting;

namespace Falcon.FalconAnalytics.Scripts.Models.Messages.PreDefines
{
	[Serializable]
	public class FInAppLog2 : BaseFalconLog
	{
		[FSortKey]
		public string productId;

		[FSortKey]
		public string where;

		public string price;

		public string currencyCode;

		public string orderId;

		public string status;

		public decimal localizedPrice;

		public string isoCurrencyCode;

		public string transactionId;

		public string purchaseToken;

		public int currentLevel;

		public new decimal inAppLtv;

		public new decimal maxInApp;

		public new string ltvIsoCurrencyCode;

		public override string Event => null;

		[Preserve]
		public FInAppLog2()
		{
		}

		public FInAppLog2(string productId, decimal localizedPrice, string isoCurrencyCode, string where, string transactionId, string purchaseToken = null, int currentLevel = 0, string orderId = "", string status = "")
		{
		}
	}
}
