using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BoosterIncreaseTime : MonoBehaviour, IBooster
{

	[SerializeField]
	private GameObject _fx;

	private const int time_increase = 60;

	public void Active(LevelController levelController)
	{
	}

	private IEnumerator CoroutineActive(LevelController levelController)
	{
		return null;
	}
}
