using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UILeaderboard_Players_Master_Item : MonoBehaviour
{
	[Serializable]
	public class Info
	{
		public Text txtName;

		public Text txtNamePremium;

		public RectTransform rectTeam;

		public Image avatarTeam;

		public Text txtTeam;

		public TextMeshProUGUI txtScore;

		public Button btnInfo;

		public void UpdateUI(UserInfoLeaderboard data)
		{
		}
	}

	public TextMeshProUGUI txtDate;

	public Info[] infos;

	public void SetItemData(int itemIndex, LeaderboardMasterUser data)
	{
	}
}
