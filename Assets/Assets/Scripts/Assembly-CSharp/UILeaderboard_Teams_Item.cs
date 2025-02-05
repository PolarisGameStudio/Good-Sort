using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UILeaderboard_Teams_Item : MonoBehaviour
{
	public RectTransform rectMine;

	public Image iconSTT;

	public Sprite[] sprIconSTTs;

	public TextMeshProUGUI txtSTT;

	public Image avatarTeam;

	public Text txtTeam;

	public TextMeshProUGUI txtScore;

	public Color[] colorNames;

	public Button btnInfo;

	private int c_itemIndex;

	private TeamInfoLeaderboard c_data;

	public int GetItemIndex => 0;

	public TeamInfoLeaderboard GetData => null;

	public bool IsYourSelf => false;

	public void SetItemData(int itemIndex, TeamInfoLeaderboard data)
	{
	}
}
