using System;
using CodeStage.AntiCheat.ObscuredTypes;

public class SpecialGoldController : NMSingleton<SpecialGoldController>
{
	public const int level_unlock = 15;

	private const string key = "special_gold";

	private SpecialGold _specialGold;

	public Action onBuy;

	public SpecialGold SpecialGold => null;

	public ObscuredInt GetGoldWhenPurchase()
	{
		return default(ObscuredInt);
	}

	protected override void Init()
	{
	}

	public void SetDataToDefault()
	{
	}

	private void OnPurchaseSuccess(string obj)
	{
	}

	private void Save()
	{
	}

	public bool IsUnlock()
	{
		return false;
	}

	public bool CanBuy()
	{
		return false;
	}

	public string GetPrice()
	{
		return null;
	}

	public string GetFakePrice()
	{
		return null;
	}

	public TimeSpan GetTime()
	{
		return default(TimeSpan);
	}

	public void Buy()
	{
	}

	public void UpdateDataFromServer(SpecialGold specialGold)
	{
	}
}
