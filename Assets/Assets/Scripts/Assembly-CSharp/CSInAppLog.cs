public class CSInAppLog : CSMessageWaitLoginSuccess
{
	public string productId;

	public string transactionId;

	public string purchaseToken;

	public string currencyCode;

	public string price;

	public string where;

	public string payload;

	public bool subscription;

	public double priceDecimal;

	public CSInAppLog(string productId, string transactionId, string purchaseToken, string currencyCode, string price, double priceDecimal, string where, string payload, bool subscription)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
