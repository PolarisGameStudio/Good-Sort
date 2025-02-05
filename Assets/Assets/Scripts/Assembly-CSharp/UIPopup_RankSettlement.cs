using System;
using System.Collections.Generic;
using SuperScrollView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_RankSettlement : MonoBehaviour
{
	[Serializable]
	public class TopUser
	{
		public TextMeshProUGUI[] txtGolds;

		public Text[] txtNames;

		public Text[] txtNamePremiums;

		public Image[] bgAvatars;

		public Image[] avatars;

		public void UpdateUI(List<LeaderBoardUserInfo> data)
		{
		}
	}

	[Header("Leaderboard")]
	public UIScrollRectSnapToChild scrollRectSnap;

	public LoopGridView loopGridView;

	[Header("Top User")]
	public TopUser topUser;

	[Header("Reward")]
	public TextMeshProUGUI txtReward;

	public Button btnClaim;

	private List<LeaderBoardUserInfo> c_data;

	private bool c_initLoopGridView;

	private int c_countLoopGridView;

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void UpdateUI()
	{
	}

	private void InitLoopGridView()
	{
	}

	private LoopGridViewItem InitLoopGridView(LoopGridView view, int itemIndex, int row, int column)
	{
		return null;
	}
}
