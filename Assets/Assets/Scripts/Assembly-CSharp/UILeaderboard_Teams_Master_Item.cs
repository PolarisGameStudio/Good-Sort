using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UILeaderboard_Teams_Master_Item : MonoBehaviour
{
	[Serializable]
	public class Info
	{
		public Text txtName;

		public TextMeshProUGUI txtScore;

		public Button btnInfo;

		public void UpdateUI(TeamInfoLeaderboard data)
		{
		}
	}

	public TextMeshProUGUI txtDate;

	public Info[] infos;

	public void SetItemData(int itemIndex, LeaderboardMasterTeam data)
	{
	}
}
