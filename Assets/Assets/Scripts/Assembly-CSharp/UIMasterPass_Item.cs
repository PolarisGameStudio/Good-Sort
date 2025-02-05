using System;
using System.Collections.Generic;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMasterPass_Item : MonoBehaviour
{
	[Serializable]
	public class Reward_Speical_Free : Reward_State
	{
		[Header("Reward")]
		public TypeReward typeDefault;

		public void UpdateUI_TypeReward((ChestType?, List<ResourceValue>) data)
		{
		}
	}

	[Serializable]
	public class Reward_Special_Gold : Reward_State
	{
		[Header("Reward")]
		public RectTransform rectBox;

		public Image avatar;

		public TextMeshProUGUI txtMaxLive;

		public void UpdateUI_TypeReward()
		{
		}
	}

	[Serializable]
	public class Reward : Reward_State
	{
		[Header("Reward")]
		public TypeReward typeDefault;

		public TypeReward typeTime;

		public TypeReward_Chest typeChest;

		public void UpdateUI_TypeReward((ChestType?, List<ResourceValue>) data)
		{
		}
	}

	[Serializable]
	public class TypeReward
	{
		public RectTransform rectBox;

		public Image icon;

		public TextMeshProUGUI txtValue;

		public void UpdateUI(ResourceValue rsValue)
		{
		}

		public void UpdateUI_Time(ResourceValue rsValue)
		{
		}
	}

	[Serializable]
	public class TypeReward_Chest
	{
		public RectTransform rectBox;

		public Image icon;

		public void UpdateUI(ChestType type)
		{
		}
	}

	[Serializable]
	public class Reward_State
	{
		public Button btnInfo;

		public SkeletonGraphic skeComplete;

		public Button btnClaim;

		public void UpdateUI_StateReward(int itemIndex, int type, (ChestType?, List<ResourceValue>) dataReward, UIMasterPass_Item item)
		{
		}
	}

	public UIMasterPass_BubbleInforItem_Manager refBubble;

	public UIMasterPass_ClaimItem_Manager refClaim;

	public Image bgSTT;

	public Sprite[] sprBGSTTs;

	public TextMeshProUGUI txtSTT;

	public RectTransform rectSTTSpecial;

	public SkeletonGraphic[] skeLockPremiums;

	public Image imgProgress;

	public RectTransform rectCurrent;

	public Image bgCurrent;

	public RectTransform[] rectLineCurrents;

	public GameObject fxLine;

	public GameObject[] fxGolds;

	[Header("Reward - Special")]
	public RectTransform rectSpecial;

	public Reward_Speical_Free rewardSpecialFree;

	public Reward_Special_Gold rewardSpecialGold;

	[Header("Reward - Normal")]
	public RectTransform rectNormal;

	public Reward rewardFree;

	public Reward rewardGold;

	[HideInInspector]
	public int c_ItemIndex;

	[HideInInspector]
	public int c_IndexRewardPassed;

	private void Start()
	{
	}

	public void SetItemData(int itemIndex, (ChestType?, List<ResourceValue>) dataFree, (ChestType?, List<ResourceValue>) dataGold)
	{
	}

	public void Tween_DisableLockPremium()
	{
	}

	public void TweenOut_LineProgress(float duration)
	{
	}

	public void TweenIn_LineProgress(float duration)
	{
	}

	public void TweenIn_Progress(float duration)
	{
	}
}
