using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIExtensions;
using DG.Tweening;
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
		public float timeMove = 0.15f;

		private bool isShow;

		public void Default()
		{
		}

		public IEnumerator IEConvertTimeToStar(UIEndGame_Showcase showcase)
		{
            var trStar = rectStar;
            var p1 = points[1].transform.position;
            var p2 = points[2].transform.position;
            rectStar.DOMove(p1, timeMove);
			yield return new WaitForSeconds(timeMove);
            rectStar.DOMove(p2, timeMove).SetEase(Ease.OutSine);
            yield return new WaitForSeconds(timeMove);
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
        txtLevel.text = $"<color=#FFD700>Level {GenLevelController.Instance.LevelId}</color>\nComplete!";
		timeRemainingConvert.txtTime.text = LogicGame.Instance.TxtTimePlay;
		StartCoroutine(StartPlayAnimConverStar());
    }

	private IEnumerator StartPlayAnimConverStar()
	{
		yield return new WaitForSeconds(0.75f);
        timeRemainingConvert.rectTime.gameObject.SetActive(false);
        timeRemainingConvert.rectStar.gameObject.SetActive(true);
		timeRemainingConvert.fxClaim.gameObject.SetActive(true);
		timeRemainingConvert.fxClaim.Play();
		yield return StartCoroutine(timeRemainingConvert.IEConvertTimeToStar(this));
		timeRemainingConvert.rectStar.gameObject.SetActive(false);
    }

	private void UpdateUI()
	{
	}
}
