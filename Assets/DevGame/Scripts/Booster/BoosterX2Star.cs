using Spine;
using Spine.Unity;
using System;
using System.Collections;
using UnityEngine;

public class BoosterX2Star : MonoBehaviour
{
	[SerializeField] SkeletonAnimation SpineStar = null;
	public void Active()
	{
		LogicGame.Instance.OnBossterX2Start();
        SpineStar.gameObject.SetActive(true);
        SpineStar.AnimationState.SetAnimation(0, "Appear", false);
		StartCoroutine(StartReset());
    }
	
	IEnumerator StartReset()
	{
		yield return new WaitForSeconds(1.2f);
        SpineStar.gameObject.SetActive(false);
    }
}
