using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine.Unity;
using UnityEngine;

public class PowerupBreakItem : MonoBehaviour, IBooster
{

	public Transform fx;

	public SkeletonAnimation anim;

	public void Active(LevelController levelController)
	{
	}

	private IEnumerator CoroutineActive(LevelController levelController)
	{
		return null;
	}
}
