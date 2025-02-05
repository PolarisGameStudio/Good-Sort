using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIShop_MasterPassPack : MonoBehaviour
{
	[Serializable]
	public class ThemePack
	{
		public MasterPassController.Theme theme;

		public RectTransform rectPack;

		public UIPopup popupBuyPremiumCompleted;
	}

	public RawImage avatar;

	public UIRect_Profile_FrameAvatar rectFrame;

	public Button btnBuy;

	public TextMeshProUGUI txtPrice;

	[Header("Themes")]
	public List<ThemePack> rectPackMasterPassByThemes;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnBuyPremium()
	{
	}

	private void UpdateUI_StatePack()
	{
	}

	private void UpdateUI()
	{
	}
}
