using System.Collections.Generic;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIEndlessPack_V3_Item : MonoBehaviour
{
	public static Image s_IconPointReward;

	[Header("Ref")]
	public UIPanel_Collection_InfoText refInfoText;

	public UIMasterPass_ClaimItem_Manager refClaim;

	[Header("Root - Reward")]
	public RectTransform rectTransform;

	public Image iconPointReward;

	public TextMeshProUGUI txtPointReward;

	public TextMeshProUGUI txtPointRewardOriginal;

	public UIPopup_ListRewards_V2_Item[] rewards;

	[Header("UI")]
	public RectTransform rectSpecial;

	public Button btnBuy;

	public TextMeshProUGUI txtPrice;

	public SkeletonGraphic skeLockSpecial;

	public RectTransform rectFree;

	public Button btnClaim;

	public SkeletonGraphic skeLockFree;

	public SkeletonGraphic skeComplete;

	private int c_ItemIndex;

	private List<ResourceValue> c_DataReward;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnClaim(int indexClaim)
	{
	}

	public void UnlockState()
	{
	}

	public void SetItemData(int itemIndex, List<ResourceValue> dataReward)
	{
	}
}
