using System;
using System.Collections.Generic;
using UnityEngine;

public class PowerupInGameController : Singleton<PowerupInGameController>
{
	[SerializeField]
	private PowerupBreakItem _boosterBreakItem;

	[SerializeField]
	private PowerupFreeze _boosterFreeze;

	[SerializeField]
	private PowerupSwap _boosterSwap;

	[SerializeField]
	private PowerupReplace _boosterReplace;

	public static Action onActiveDone;

	private List<PowerupKind> _powerupInQueue;

	private bool _isLimited;

	public Dictionary<PowerupKind, int> powerupAdRemain;

	private int _numAdsPowerupPerLevel;

	public static Action<PowerupKind> onActivePowerup;

	public static Dictionary<PowerupKind, string> _dicItemName;

	public static Dictionary<PowerupKind, string> _dicItemNameLevelLevlUse;

	public static bool isTut;

	public static List<PowerupKind> powerupActived;

	public static Action onTutCompleted;

	public bool IsLimited => false;

	public int numAdsPowerupPerLevel => 0;

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public void ActivePowerup(PowerupKind powerup)
	{
	}

	public void TutComplete()
	{
	}

	public void ForceActivePowerup(PowerupKind powerup)
	{
	}

	public void AddPowerupToQueue(PowerupKind powerup)
	{
	}

	public void ActiveNextPowerupInQueue()
	{
	}
}
