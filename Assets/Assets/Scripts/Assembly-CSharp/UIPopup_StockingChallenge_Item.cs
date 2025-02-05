using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_StockingChallenge_Item : MonoBehaviour
{
	public CanvasGroup viewport;

	public RectTransform rectMine;

	public Image iconSTT;

	public Sprite[] sprIconSTTs;

	public TextMeshProUGUI txtSTT;

	public TextMeshProUGUI txtSTTMine;

	public Text txtName;

	public Text txtNameMine;

	public Text txtNamePremium;

	public Image avatar;

	public UIRect_Profile_FrameAvatar rectFrameAvatar;

	public UIRect_Profile_Badge rectBadge;

	public Button btnReward;

	public Image iconReward;

	public Sprite[] sprIconRewards;

	public TextMeshProUGUI txtScore;

	public UIPanel_UnlockReward_Info refBubbleReward;

	private int c_itemIndex;

	private StockingUser c_data;

	public int GetItemIndex => 0;

	public StockingUser GetData => null;

	public void UpdateViewport(bool isShow)
	{
	}

	public void SetItemData(int itemIndex, StockingUser data, float score)
	{
	}

	private int GetIndexIconReward(int itemIndex)
	{
		return 0;
	}
}
