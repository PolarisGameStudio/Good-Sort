using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIEndGame_Showcase_ClaimChest : MonoBehaviour
{
	
	public Slider progress;

	public TextMeshProUGUI txtProgress;

	public SkeletonGraphic skeChest;

	private void Start()
	{
	}

	private IEnumerator IEUpdateUI()
	{
		return null;
	}

	private bool IsUnlockOpenChest()
	{
		return false;
	}
}
