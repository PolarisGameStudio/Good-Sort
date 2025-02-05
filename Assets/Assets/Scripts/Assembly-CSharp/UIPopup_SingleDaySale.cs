using System.Collections.Generic;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_SingleDaySale : MonoBehaviour
{
	public UITimerCountdownTMP timer;

	[Header("Reward")]
	public UIPopup_SingleDaySale_Item[] items;

	[Header("Reward Frame")]
	public Image avatar;

	public UIRect_Profile_FrameAvatar rectFrame;

	public RectTransform rectTextDes;

	public SkeletonGraphic skeClaimed;

	private bool c_IsContainFrame;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnBuyPack(List<ResourceValue> dataReward)
	{
	}

	private void UpdateUI()
	{
	}

	private void UpdateUI_RewardFrame()
	{
	}
}
