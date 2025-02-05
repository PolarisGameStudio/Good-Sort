using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine.Unity;
using UnityEngine;

public class PowerupReplace : MonoBehaviour, IBooster
{

	public Transform container;

	[SerializeField]
	private MagicWard _magicWard;

	[SerializeField]
	private SkeletonAnimation _spineWand;

	[SerializeField]
	private Transform _fxWand;

	[SerializeField]
	private ParticleSystem _fxBurst;

	public void Active(LevelController levelController)
	{
	}

	private IEnumerator CoroutineActive(LevelController levelController)
	{
		return null;
	}
}
