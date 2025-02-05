using System;
using System.Collections.Generic;

public class PiggyBankController : NMSingleton<PiggyBankController>
{
	private const string key = "piggy";

	private PiggyBank _piggyBank;

	private bool _isJustUpdateGold;

	public int numHourCoooldownWhenFull;

	private List<float> ratios;

	public Action onBuy;

	public PiggyBank PiggyBank => null;

	public bool IsJustUpdateGold => false;

	public int GoldPerLevel => 0;

	protected override void Init()
	{
	}

	private int PiggyType()
	{
		return 0;
	}

	public PiggyBankSheet GetPiggyData()
	{
		return null;
	}

	public void ConfirmJutstUpdateGold()
	{
	}

	private void OnSceneChange(SceneState state)
	{
	}

	private void CheckTime()
	{
	}

	private void CompleteLevel()
	{
	}

	public TimeSpan GetTimeSpanReset()
	{
		return default(TimeSpan);
	}

	public void InitData()
	{
	}

	public void SetDataToDefault()
	{
	}

	private void Save()
	{
	}

	private void ValidateData()
	{
	}

	public bool IsMaxValue()
	{
		return false;
	}

	public bool IsActive()
	{
		return false;
	}

	public bool CanBuy()
	{
		return false;
	}

	public int GetTarget1()
	{
		return 0;
	}

	public int GetTarget2()
	{
		return 0;
	}

	public float GetFillRatio()
	{
		return 0f;
	}

	public int GetSaleOffPercent()
	{
		return 0;
	}

	public string GetFakePrice()
	{
		return null;
	}

	public string GetPrice()
	{
		return null;
	}

	public string GetProduct()
	{
		return null;
	}

	public void Buy()
	{
	}

	public void UpdateDataFromServer(PiggyBankServer piggyBank)
	{
	}
}
