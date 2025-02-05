using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine.Unity;
using UnityEngine;

public class BoosterBuffCombo : MonoBehaviour, IBooster
{
	
	[SerializeField]
	private SkeletonAnimation _spine;

	[SerializeField]
	private GameObject _container;

	[SerializeField]
	private GameObject _fxBullet;

	[SerializeField]
	private GameObject _fxMuzzle;

	[SerializeField]
	private GameObject _fxImpact;

	[SerializeField]
	private GameObject _fxCombo;

	public static Action<BoosterKind> onFireBulletComplete;

	public void Active(LevelController levelController)
	{
	}

	private IEnumerator DelayActive(LevelController levelController)
	{
		return null;
	}
}
