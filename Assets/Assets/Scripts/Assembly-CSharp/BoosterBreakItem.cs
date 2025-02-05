using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine.Unity;
using UnityEngine;

public class BoosterBreakItem : MonoBehaviour, IBooster
{
	[SerializeField]
	private Transform _bg;

	[SerializeField]
	private SkeletonAnimation _anim;

	public void Active(LevelController levelController)
	{
	}

	private IEnumerator CoroutineActive(LevelController levelController)
	{
		return null;
	}
}
