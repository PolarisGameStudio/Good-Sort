using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_TeamTreasure_Reward : MonoBehaviour
{
	public Slider[] sliders;

	public TextMeshProUGUI[] txtTargets;

	public SkeletonGraphic[] skeIcons;

	public SkeletonGraphic[] skeIconOriginals;

	public SkeletonGraphic[] skeCompletes;

	public Button[] btnClaims;

	public Button[] btnInfos;

	public UIPanel_UnlockReward_Info[] panelInfos;

	public RectTransform refRectLockUI;

	private Vector2[] sizeSliderOriginals;

	private SkeletonGraphic c_SkeCompleteSelected;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnClaimReward(int index)
	{
	}

	public void UpdateUI()
	{
	}

	private void SetItemData(int itemIndex, RewardState stateReward)
	{
	}
}
