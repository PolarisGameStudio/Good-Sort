using System;
using System.Collections;
using System.Collections.Generic;
using Coffee.UIExtensions;
using DG.Tweening;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

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

	[Header("Progress Level")]
    public Slider progressLevel = null;
	public TextMeshProUGUI txtMeshComplete = null;

	[Header("skeChes")]
	public SkeletonGraphic skeChes = null;



    public static void ConfirmClickClaimGold()
	{

	}

	private void OnEnable()
	{
		HelperManager.DataPlayer.NumWinLevel += 1;
		txtMeshComplete.text = $"{HelperManager.DataPlayer.NumWinLevel}/5";
        StartCoroutine(StartPlayAnimProgressComplete());
        txtLevel.text = $"<color=#FFD700>Level {GenLevelController.Instance.LevelId + 1}</color>\nComplete!";
		timeRemainingConvert.txtTime.text = LogicGame.Instance.TxtTimePlay;
		timeRemainingConvert.txtStar.text = "5";
        txtTotalStar.text = HelperManager.DataPlayer.currentStarGame.ToString();
        StartCoroutine(StartPlayAnimConverStar());
    }

	private IEnumerator StartPlayAnimProgressComplete()
	{
		yield return new WaitForEndOfFrame();
		float Move = (float) HelperManager.DataPlayer.NumWinLevel / 5.0f;
		progressLevel.DOValue(Move, 0.25f);
		yield return new WaitForSeconds(0.25f);
       // if (HelperManager.DataPlayer.NumWinLevel >= 5)
        {
            HelperManager.DataPlayer.NumWinLevel = 0;
            OnShowUnLockReward(() =>
            {
               
            });
            yield return new WaitForEndOfFrame();
            yield return new WaitForEndOfFrame();
        }
    }

    private void OnShowUnLockReward(Action callback)
	{
        Audio.Play(ScStatic.SFX_UI_Chest_Open);
        UIPopup_UnlockRewards.Show();
        List<ResourceType> resourceTypes = new List<ResourceType>() {
            ResourceType.Powerup_BreakItem,
            ResourceType.Powerup_Replace,
            ResourceType.Powerup_Freeze ,
            ResourceType.Powerup_Swap,
            ResourceType.Booster_X2_Star,
            ResourceType.Booster_BreakItem,
            ResourceType.Booster_Time,
            ResourceType.Gold,
        };

        int rand = UnityEngine.Random.Range(1, 3);

        HelperManager.Shuffle(resourceTypes);

        List<ResourceType> listType = new();

        for (int i = 0; i < rand; i++)
        {
            listType.Add(resourceTypes[0]);
            resourceTypes.RemoveAt(0);
        }
        List<ResourceValue> listValue = new();
        foreach (var ty in listType)
        {
            int valueAdd = 1;



            listValue.Add(new(ty, 1));
        }
        UIPopup_UnlockRewards.Instance.UpdateUI_SkeletonChest(skeChes, listValue, 0.01f, 0.425f, 0.25f, callback);
    }

    private IEnumerator StartPlayAnimConverStar()
	{
		yield return new WaitForSeconds(0.75f);
        timeRemainingConvert.rectTime.gameObject.SetActive(false);
        timeRemainingConvert.rectStar.gameObject.SetActive(true);
		timeRemainingConvert.fxClaim.gameObject.SetActive(true);
		timeRemainingConvert.fxClaim.Play();
        Audio.Play(ScStatic.SFX_Ingame_StartWave);
		yield return StartCoroutine(timeRemainingConvert.IEConvertTimeToStar(this));
		timeRemainingConvert.rectStar.gameObject.SetActive(false);
        txtTotalStar.text = (HelperManager.DataPlayer.currentStarGame + 5).ToString();
        HelperManager.DataPlayer.currentStarGame += 5;
    }

    private void UpdateUI()
	{
	}
}
