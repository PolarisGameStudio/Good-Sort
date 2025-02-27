using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIExtensions;
using TMPro;
using UnityEngine;

public class UIEndGame_Showcase : MonoBehaviour
{
	[Serializable]
	public class TimeRemainingConvert
	{
		
		public RectTransform rectTime;

		public TextMeshProUGUI txtTime;

		public RectTransform rectStar;

		public TextMeshProUGUI txtStar;

		public RectTransform[] points;

		public UIParticle fxClaim;

		private bool isShow;

		public void Default()
		{
		}

		public IEnumerator IEConvertTimeToStar(UIEndGame_Showcase showcase)
		{
			return null;
		}
	}

    public UIPanel_InGame_Leaderboard_PiggyBank uiPanelPiggyBank;

    public TextMeshProUGUI txtLevel;

    public UIEndGame_Showcase_ClaimGold panelClaimGold;

    [Header("Star")]
	public TextMeshProUGUI txtTotalStar;

	public UIParticle fxStarIncrease;

	[Header("Time Convert Star")]
	public TimeRemainingConvert timeRemainingConvert;

	public static void ConfirmClickClaimGold()
	{
	}

	private void OnEnable()
	{
	}

	private void UpdateUI()
	{
	}
}
