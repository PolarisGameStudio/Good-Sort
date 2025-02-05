using System;
using Falcon.FalconAnalytics.Scripts.Models.Messages.PreDefines;
using UnityEngine.Scripting;

[Serializable]
public class FInAppLogNew : FInAppLog
{
	public string eventCheck;

	[Preserve]
	public FInAppLogNew()
	{
	}

	public FInAppLogNew(string productId, decimal localizedPrice, string isoCurrencyCode, string where, string transactionId, string purchaseToken, int currentLevel, string eventCheck)
	{
	}
}
