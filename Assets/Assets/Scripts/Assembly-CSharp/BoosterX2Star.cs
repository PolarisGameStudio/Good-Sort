using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BoosterX2Star : MonoBehaviour, IBooster
{

	public void Active(LevelController levelController)
	{
	}

	private IEnumerator DelayActive(LevelController levelController)
	{
		return null;
	}
}
