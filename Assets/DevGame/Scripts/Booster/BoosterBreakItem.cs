using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine.Unity;
using UnityEngine;

public class BoosterBreakItem : MonoBehaviour
{
	[SerializeField]
	private Transform _bg;

	[SerializeField]
	private SkeletonAnimation _anim;

	public void Active()
	{
		LogicGame.Instance.OnSkillBreakItem(true);
        _bg.gameObject.SetActive(true);
		StartCoroutine(ActiveBg());
    }

    IEnumerator ActiveBg()
	{
		yield return new WaitForSeconds(1.94f);
        _bg.gameObject.SetActive(false);

    }	
}
