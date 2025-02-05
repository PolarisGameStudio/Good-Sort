using System;
using System.Collections.Generic;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIEndlessPack_V2_Item : MonoBehaviour
{
	[Serializable]
	public class Reward
	{
		public RectTransform rectItem;

		public RectTransform rectDefault;

		public Image icon;

		public TextMeshProUGUI txtValue;

		public RectTransform rectGold;

		public TextMeshProUGUI txtValueGold;

		public Button btnInfo;

		public void SetItem(ResourceValue data)
		{
		}

		public void SetItem_Chest(UIEndlessPack_V2_Item item, ChestType chestType, List<ResourceValue> dataReward)
		{
		}
	}

	public UIMasterPass_BubbleInforItem_Manager refBubble;

	public UIMasterPass_ClaimItem_Manager refClaim;

	public RectTransform rectTransform;

	public RectTransform rootReward;

	public Reward[] rewards;

	public RectTransform rectSpecial;

	public Button btnBuy;

	public TextMeshProUGUI txtPrice;

	public SkeletonGraphic skeLockSpecial;

	public RectTransform rectFree;

	public Button btnClaim;

	public SkeletonGraphic skeLockFree;

	public SkeletonGraphic skeComplete;

	public RectTransform rectComingSoon;

	public UITimerCountdownTMP timerComingSoon;

	private int c_ItemIndex;

	private List<ResourceValue> c_DataReward;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnClaim(int indexClaim)
	{
	}

	public void UnlockState()
	{
	}

	public void SetItemData(int itemIndex, ChestType? chestType, List<ResourceValue> dataReward, bool isComingSoon = false)
	{
	}
}
