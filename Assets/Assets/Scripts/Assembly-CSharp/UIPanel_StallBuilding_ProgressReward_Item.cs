using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_StallBuilding_ProgressReward_Item : MonoBehaviour
{
	public UIPopup_ListRewards_V2_Item itemDefault;

	public Button btnBoxReward;

	public SkeletonGraphic[] skeChests;

	public SkeletonGraphic skeLastChest;

	public RectTransform rectCompleted;

	private int c_ItemIndex;

	public SkeletonGraphic GetSkeChest()
	{
		return null;
	}

	public void SetItemData(UIPanel_StallBuilding_ProgressReward manager, int itemIndex)
	{
	}

	public void SetAnimLastChest()
	{
	}

	public void SetStateClaimed()
	{
	}
}
