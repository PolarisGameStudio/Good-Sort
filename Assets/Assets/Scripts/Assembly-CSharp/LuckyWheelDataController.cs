using System;
using System.Collections.Generic;

public class LuckyWheelDataController : NMSingleton<LuckyWheelDataController>
{
	private const string key = "lucky_wheel";

	private const int level_unlock = 11;

	private bool _isFirstSession;

	private int _numReward;

	private LuckyWheel _luckyWheel;

	public Action<int, List<ResourceValue>> onSpin;

	public LuckyWheel LuckyWheel => null;

	protected override void Init()
	{
	}

	public void SetDataToDefault()
	{
	}

	private void SceneChange(SceneState state)
	{
	}

	private void Save()
	{
	}

	public void CheckTime()
	{
	}

	public ResourceValue GetResourceValue(int index)
	{
		return null;
	}

	public ResourceValue GetShovelResource(int index)
	{
		return null;
	}

	public ResourceValue GetGiftHiddenResource(int index)
	{
		return null;
	}

	public ResourceValue GetEnvelopResource(int index)
	{
		return null;
	}

	public bool IsUnlock()
	{
		return false;
	}

	public bool CanShowPopup()
	{
		return false;
	}

	public TimeSpan GetTime()
	{
		return default(TimeSpan);
	}

	public bool CanSpin()
	{
		return false;
	}

	public (int, int) GetNumberSpin()
	{
		return default((int, int));
	}

	public void Spin()
	{
	}

	public void UpdateDataFromServer(LuckyWheelServer luckyWheel)
	{
	}
}
