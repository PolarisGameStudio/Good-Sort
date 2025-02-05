using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_TeamBattle_Battle_Item : MonoBehaviour
{
	[Serializable]
	public class Score
	{
		public RectTransform rectScore;

		public TextMeshProUGUI txtScore;
	}

	public CanvasGroup viewport;

	public RectTransform rectMine;

	public Image iconRankTop3;

	public Sprite[] sprIconRankTop3;

	public RectTransform rectRank;

	public TextMeshProUGUI txtRank;

	public TextMeshProUGUI txtRankMine;

	public Image avatar;

	public Text txtName;

	public Text txtNameMine;

	public RectTransform rectReward;

	public Image iconReward;

	public Sprite[] sprIconRewards;

	public TextMeshProUGUI txtValueReward;

	public Score score;

	public Score scoreMine;

	[Header("Button Info")]
	public Button btnInfoItem;

	public Button btnInfoReward;

	public Button btnInfoScore;

	public UIPanel_Collection_InfoText refUIPanelInfoText;

	private int c_itemIndex;

	private TeamBattleInfo c_data;

	public int GetItemIndex => 0;

	public TeamBattleInfo GetData => null;

	public bool IsYourSelf => false;

	private void Start()
	{
	}

	public void UpdateViewport(bool isShow)
	{
	}

	public void SetItemData(int itemIndex, TeamBattleInfo data)
	{
	}
}
