using System;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_FoodDuel_Leaderboard_Item : MonoBehaviour
{
	[Serializable]
	public class Score
	{
		public RectTransform rectScore;

		public TextMeshProUGUI txtScore;
	}

	[Header("Ref")]
	public UIPanel_UnlockReward_Info refPanelUnlockReward;

	public UIPanel_Collection_InfoText refUIPanelInfoText;

	[Header("UI")]
	public RectTransform rectMine;

	public TextMeshProUGUI txtRank;

	public TextMeshProUGUI txtRankMine;

	public Text txtName;

	public Text txtNameMine;

	public Text txtNamePremium;

	public RawImage avatar;

	public UIRect_Profile_FrameAvatar rectFrameAvatar;

	public UIRect_Profile_Badge rectBadge;

	public Score score;

	public Score scoreMine;

	public Button btnInfoItem;

	public Button btnInfoScore;

	[Header("Reward")]
	public Button btnInfoReward;

	public SkeletonGraphic[] skeChests;

	private UserInfoEventPVP c_data;

	public bool IsYourSelf => false;

	public void SetItemData(UserInfoEventPVP data)
	{
	}
}
