using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_EndGame_Shop_MasterPassPack : MonoBehaviour
{
	[Serializable]
	public class ThemePack
	{
		public MasterPassController.Theme theme;

		public RectTransform rectPack;

		public RectTransform rectIconSpecialChest;

		public UIPopup popupBuyPremium;
	}

	public RawImage avatar;

	public UIRect_Profile_FrameAvatar rectFrame;

	public Button btnActive;

	public Image iconRewardBonus;

	[Header("Themes")]
	public List<ThemePack> rectPackMasterPassByThemes;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void UpdateUI_StatePack()
	{
	}

	private void UpdateUI()
	{
	}
}
