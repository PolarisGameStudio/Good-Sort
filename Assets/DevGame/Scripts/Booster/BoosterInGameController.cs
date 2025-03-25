using System;
using System.Collections.Generic;
using UnityEngine;

public class BoosterInGameController : Singleton<BoosterInGameController>
{
	public static Action onActiveDone;

	[SerializeField]
	private BoosterBreakItem _boosterBreakItem;

	[SerializeField]
	private BoosterX2Star _boosterX2Star;

	[SerializeField]
	private BoosterIncreaseTime _boosterIncreaseTime;

	protected override void Awake()
	{
	}

	public void ActiveBooster(BoosterKind booster, float time = 0)
	{
		if(booster == BoosterKind.IncreaseTime)
		{
			_boosterIncreaseTime.Active(time);
        }

		if(booster == BoosterKind.BreakItem)
		{
			_boosterBreakItem.Active();
		}

		if(booster == BoosterKind.X2_Star)
		{
            _boosterX2Star.Active();
		}

	}

	
}
