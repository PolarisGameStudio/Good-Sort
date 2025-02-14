using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine.Unity;
using UnityEngine;

public class PowerupReplace : MonoBehaviour
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

	public void Active(List<Item> listCell)
	{
		foreach(var cel in listCell)
		{
			var item = Instantiate(cel, null);
			var wiza = item.GetComponent<MagicWard>();
            wiza.SetPos(transform.position, cel.transform.position);
		}

		StartCoroutine(PlayAnimation(listCell));
	}


	IEnumerator PlayAnimation(List<Item> listCell)
	{
		_spineWand.AnimationState.SetAnimation(0, "Start", false);
		float time = _spineWand.AnimationState.GetCurrent(0).AnimationTime;
		yield return new WaitForSeconds(time);
        _spineWand.AnimationState.SetAnimation(0, "Start_Idle", false);
        time = _spineWand.AnimationState.GetCurrent(0).AnimationTime;
        _fxWand.gameObject.SetActive(true);
        yield return new WaitForSeconds(time);
        _spineWand.AnimationState.SetAnimation(0, "Stop", false);

		foreach(var cel in listCell)
		{
			var anim = Instantiate(_fxBurst, cel.transform);
            anim.transform.localPosition = Vector3.zero;

        }

    }

}
