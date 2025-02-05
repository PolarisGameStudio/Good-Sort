using System;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_ExclusiveReward : MonoBehaviour
{
	public RectTransform rectAvatar;

	public Image avatar;

	public UIRect_Profile_FrameAvatar rectFrameAvatar;

	public UIRect_Profile_Badge rectBadge;

	public Button btnEquip;

	private void OnDisable()
	{
	}

	public void UpdateUI_EquipFrameAvatar(int frameID)
	{
	}

	public void UpdateUI_EquipBadge(int badgeID)
	{
	}

	public static void OpenUI_FrameAvatar(int frameID, Action OnCloseUI)
	{
	}

	public static void OpenUI_Badge(int badgeID, Action OnCloseUI)
	{
	}
}
