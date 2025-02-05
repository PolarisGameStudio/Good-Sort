using System;
using System.Collections.Generic;
using UnityEngine;

public class BoosterInGameController : Singleton<BoosterInGameController>
{
	private Dictionary<BoosterKind, IBooster> _booster;

	public static Action onActiveDone;

	[SerializeField]
	private BoosterBreakItem _boosterBreakItem;

	[SerializeField]
	private BoosterX2Star _boosterX2Star;

	[SerializeField]
	private BoosterIncreaseTime _boosterIncreaseTime;

	public Action<BoosterKind> onActiveBooster;

	public static Dictionary<BoosterKind, string> dic_item_name;

	public static Dictionary<BoosterKind, string> dic_item_name_level_use;

	public static List<BoosterKind> boosterActived;

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void ActiveBoosterWhenStart()
	{
	}

	private bool HasBooster()
	{
		return false;
	}

	private bool ContainsBooster(BoosterKind booster)
	{
		return false;
	}

	private void ActiveBooster()
	{
	}

	public void ActiveBooster(BoosterKind booster)
	{
	}

	public void ForceActiveBooster(BoosterKind boosterInGame)
	{
	}
}
