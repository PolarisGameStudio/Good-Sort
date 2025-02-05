using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIExtensions;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_StarRush : MonoBehaviour
{
	[Serializable]
	public class ShowcaseEnd
	{
		public RectTransform rectEnd;

		public Image iconSTT;

		public SkeletonGraphic skeIconChest;

		public RectTransform rectEmptyReward;

		public UIParticle fxConfeti;

		public RectTransform rectBtnClaim;

		public Button btnClaim;

		public RectTransform rectBtnContinue;

		public Button btnContinue;

		public void OpenUI(UIPopup_StarRush manager, UserStarRushInfo myData)
		{
		}

		public void Default()
		{
		}
	}

	public static Action OnCloseUI;

	public RectTransform rectPoints;

	public UIPopup_StarRush_Item[] items;

	public UITimerCountdownTMP timer;

	public Button btnHelp;

	public UIPopup popupHelp;

	[Header("Showcase")]
	public ShowcaseEnd showcaseEnd;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private IEnumerator IEUpdateUI()
	{
		return null;
	}
}
