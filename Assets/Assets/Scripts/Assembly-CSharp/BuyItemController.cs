using System;
using System.Collections.Generic;
using UnityEngine;

public class BuyItemController : Singleton<BuyItemController>
{


	public Transform fx;

	private static readonly Dictionary<PowerupKind, AdRewardType> _dicAdKind;

	public static int GetGoldToBuyPowerup(PowerupKind powerupKind)
	{
		return 0;
	}

	public PowerupKind GetPowerupWhenOutOfSpace()
	{
		return default(PowerupKind);
	}

	public void ActiveItemFreeWhenBuyMasterPass()
	{
	}

	public bool CanBuyPowerUp(PowerupKind powerupKind)
	{
		return false;
	}

	public void BuyPowerupInGame(PowerupKind powerupKind)
	{
	}

	public void BuyPowerupInGame(PowerupKind powerupKind, List<PowerupKind> powerupKindsBonusByGold, int price)
	{
	}

	private void ActivePowerup(PowerupKind powerupKind)
	{
	}

	public void WatchAdsToUsePowerUp(PowerupKind powerupKind, Action onWatchComplete)
	{
	}

	public void WatchAdsToUsePowerUp(PowerupKind powerupKind, List<PowerupKind> powerupKindsBonusByAds, Action onWatchComplete)
	{
	}

	public bool CanBuyTime()
	{
		return false;
	}

	public void BuyTimeWhenTimeOut(int price, int timeAmount)
	{
	}

	public void WatchAdsToBuyTime(Action onWatchComplete, int timeAmount)
	{
	}

	private void AddMoreTime()
	{
	}

	private void AddMoreTime(int timeAmount)
	{
	}
}
