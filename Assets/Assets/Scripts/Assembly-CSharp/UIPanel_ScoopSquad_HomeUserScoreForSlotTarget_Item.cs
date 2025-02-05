using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_ScoopSquad_HomeUserScoreForSlotTarget_Item : MonoBehaviour
{
	public Text txtName;

	public Text txtNamePremium;

	public RawImage avatar;

	public UIRect_Profile_FrameAvatar rectFrameAvatar;

	public UIRect_Profile_Badge rectBadge;

	public TextMeshProUGUI txtScore;

	public TextMeshProUGUI txtScoreAdd;

	public Button btnViewProfile;

	private int c_Score;

	public void SetItemData(UserSimpleInfo data, int score)
	{
	}

	public void DefaultTweenAddScore()
	{
	}

	public void UpdateScore(int scoreAdd)
	{
	}
}
