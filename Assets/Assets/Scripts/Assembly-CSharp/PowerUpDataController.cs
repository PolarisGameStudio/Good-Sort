using System;
using System.Collections.Generic;

public class PowerUpDataController : NMSingleton<PowerUpDataController>
{
	private const string key = "power_up";

	private PowerupData _powerupData;

	public static Action<int> onUsePowerup;

	private const int num_item_for_tut = 1;

	private PowerupKind? powerupKindTut;

	public static readonly Dictionary<PowerupKind, string> DicPowerupNameToLog;

	public PowerupData PowerupData => null;

	private int numPowerupInit => 0;

	protected override void Init()
	{
	}

	private void OnChangeScene(SceneState state)
	{
	}

	public void CheckingDataFromRemoteConfig()
	{
	}

	public void SetDataToDefault()
	{
	}

	private void InitData()
	{
	}

	private void Save()
	{
	}

	public int GetNumPowerup(PowerupKind powerup)
	{
		return 0;
	}

	public int GetNumPowerupFree(PowerupKind powerup)
	{
		return 0;
	}

	public void AddPowerup(PowerupKind powerup, int num)
	{
	}

	public void AddPowerupFree(PowerupKind powerup, int num)
	{
	}

	public bool CanUsePowerup(PowerupKind powerupKind)
	{
		return false;
	}

	public void UserPowerup(PowerupKind powerup, int num, string where)
	{
	}

	private void MinusPowerup(PowerupKind powerup, int num, string where)
	{
	}

	private void MinusPowerupFree(PowerupKind powerup, int num)
	{
	}

	public int GetLevelUnLockPowerup(PowerupKind kind)
	{
		return 0;
	}

	public bool IsFree(PowerupKind powerupKind)
	{
		return false;
	}

	public PowerupKind? GetTutPowerup()
	{
		return null;
	}

	public bool IsUnLockPowerup(PowerupKind kind)
	{
		return false;
	}

	public void AddItemForTut(PowerupKind kind)
	{
	}

	public bool IsTut(PowerupKind kind)
	{
		return false;
	}

	public void ActivePowerupTut()
	{
	}

	public void UpdateDataFromServer(PowerupDataServer powerup)
	{
	}
}
