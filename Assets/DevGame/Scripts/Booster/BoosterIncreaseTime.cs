using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BoosterIncreaseTime : MonoBehaviour
{

	[SerializeField]
	private GameObject _fx;

	private const int time_increase = 60;

	public void Active(float time)
	{
		var fx = Instantiate(_fx, null);
		fx.transform.position = Vector3.zero;
		LogicGame.Instance.OnBossterTimeBonus(fx.transform, time);
    }
}
