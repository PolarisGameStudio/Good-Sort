using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIExtensions;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_UnlockCollection_CardSet : MonoBehaviour
{

	public static Action OnGetCardComplete;

	[Header("UI")]
	public UIPopup_UnlockCollection_CardSet_Pack pack;

	public UIChest_PatternPositionReward_Item pattern;

	public Button btnTap;

	public UIParticle _fxDoubleTap;

	[Header("Fx")]
	public UIParticle[] fxItemPremiums;

	public UIParticle[] fxItemDisapears;

	[Header("Recycle Card -> Star")]
	public UIRect_UnlockCollection_Star_Recycle_Item[] starRecycles;

	public DOTweenAnimation tweenStarRecycle;

	public RectTransform rectIconChestRecycle;

	public ParticleSystem fxStarRecycle;

	private List<DataOpenCollectionPack> c_listData;

	private DataOpenCollectionPack c_data;

	private RectTransform c_target;

	private float c_scale;

	private bool c_CanTapScreenSkipAnimation;

	private float c_lastDoubleTapTime;

	private float lastTapTime;

	private float maxTapInterval;

	private float doubleTapCooldown;

	private void LateUpdate()
	{
	}

	private void OnDisable()
	{
	}

	private void HandleTap(float currentTapTime)
	{
	}

	private void OnDestroy()
	{
	}

	public static void OpenUI(RectTransform target, float scale = 1f, Action OnCloseUI = null)
	{
	}

	public static void OpenUI(Action OnCloseUI = null)
	{
	}

	public void UpdateUI(List<DataOpenCollectionPack> data, RectTransform target, float scale)
	{
	}

	public void UpdateUI(List<DataOpenCollectionPack> data)
	{
	}

	public void StartAnimation_GetCardInCollectionPack(DataOpenCollectionPack data)
	{
	}

	private IEnumerator IEPushCard()
	{
		return null;
	}

	private IEnumerator IEFlipCardPremium()
	{
		return null;
	}

	private IEnumerator IEShowTapContinue()
	{
		return null;
	}

	private void CloseUI()
	{
	}

	private IEnumerator IECloseUIPopup()
	{
		return null;
	}

	private bool IsHaveStarRecycle(List<CardData> data)
	{
		return false;
	}
}
