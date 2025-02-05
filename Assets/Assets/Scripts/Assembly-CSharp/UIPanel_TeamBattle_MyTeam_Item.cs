using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_TeamBattle_MyTeam_Item : MonoBehaviour
{
	[Serializable]
	public class Score
	{
		public RectTransform rectScore;

		public TextMeshProUGUI txtScore;
	}

	public RectTransform rectMine;

	public Image iconRankTop3;

	public Sprite[] sprIconRankTop3;

	public RectTransform rectRank;

	public TextMeshProUGUI txtRank;

	public TextMeshProUGUI txtRankMine;

	public Text txtName;

	public Text txtNameMine;

	public Text txtNamePremium;

	public RawImage avatar;

	public UIRect_Profile_FrameAvatar rectFrameAvatar;

	public UIRect_Profile_Badge rectBadge;

	public UIPopup_ListRewards_V2_Item reward;

	public Score score;

	public Score scoreMine;

	[Header("Button Info")]
	public Button btnInfoItem;

	public Button btnInfoReward;

	public Button btnInfoScore;

	public UIPanel_Collection_InfoText refUIPanelInfoText;

	private int c_itemIndex;

	private UserInfoTeamBattle c_data;

	public int GetItemIndex => 0;

	public UserInfoTeamBattle GetData => null;

	public bool IsYourSelf => false;

	private void Start()
	{
	}

	public void SetItemData(int itemIndex, UserInfoTeamBattle data)
	{
	}
}
