using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIExtensions;
using DG.Tweening;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_HiddenTreasure : MonoBehaviour
{
	[Serializable]
	public class ReadyToPlay
	{
		public RectTransform rectShowcase;

		public Image BG;

		public RectTransform rectTarget;

		private float duration;

		public IEnumerator IEUpdateUI(UIPopup_HiddenTreasure manager, RectTransform targetFromFindPlayer, Action onComplete)
		{
			return null;
		}
	}

	[Serializable]
	public class Congratulation
	{
		public UIPopup popup;

		public TextMeshProUGUI txtGold;

		public TextMeshProUGUI txtPlayer;

		public UIHiddenTreasure_Player[] avatarPlayers;

		public void OpenUI()
		{
		}
	}

	public UITimerCountdownTMP uITimerCountdown;

	public Button btnHelp;

	public UIPopup popupHelp;

	public TextMeshProUGUI txtDes;

	public DOTweenAnimation tweenTitle;

	public UIHiddenTreasure_Reward uiReward;

	public RectTransform rectTapToContinue;

	[Header("Info")]
	public TextMeshProUGUI txtLevel;

	public TextMeshProUGUI txtMaxLevel;

	public UIParticle fxLevel;

	public TextMeshProUGUI txtPlayer;

	public TextMeshProUGUI txtMaxPlayer;

	public UIParticle fxPlayer;

	[Header("All Player")]
	public UIHiddenTreasure_Target[] targets;

	public UIHiddenTreasure_Player[] players;

	public float[] scalePlayers;

	public SkeletonGraphic skeJumpboard;

	public CanvasGroup viewportPlayers;

	[Header("Showcase")]
	public ReadyToPlay readyToPlay;

	public Congratulation congratulation;

	public RectTransform rectFail;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void UpdateUI()
	{
	}

	public void UpdateUI_ReadyToPlay(RectTransform targetFromFindPlayer)
	{
	}

	private void UpdateScalePlayers()
	{
	}

	private void UpdateUI_Start(int indexTarget)
	{
	}

	private void UpdateUI(int indexTarget)
	{
	}

	private void OnComplete()
	{
	}
}
