using Coffee.UIExtensions;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_ScoopSquad_SlotTarget_Item : MonoBehaviour
{
	public RectTransform rectTransform;

	public Button btnInfo;

	public SkeletonGraphic[] skeIcreams;

	public RectTransform rectLockUI;

	public UIParticle fx;

	private int c_IndexSlot;

	private int c_preState;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnClaimRewardProgress(int indexSlot, int indexReward)
	{
	}

	public void SetItemData(UIPopup_ScoopSquad refManager, int indexSlot)
	{
	}

	private void UpdateUI_NextPreviewIceCream(int preState)
	{
	}

	private void DisableIceCreams()
	{
	}
}
