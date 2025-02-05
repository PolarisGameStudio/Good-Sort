using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_LuxuryChest : MonoBehaviour
{

	public GameObject viewport;

	public Slider progress;

	public TextMeshProUGUI txtProgress;

	public RectTransform rectIconChest;

	public SkeletonGraphic skeIconChest;

	public Button btnContinue;

	public RectTransform rectLock;

	private List<LuxuryResource> luxuryResources;

	private int indexLuxuryRs;

	private bool c_IsUnlockRewards;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private IEnumerator IEStackReward()
	{
		return null;
	}
}
