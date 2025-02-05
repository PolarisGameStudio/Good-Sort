using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_ViewProfile : MonoBehaviour
{
	public int Code;

	public RectTransform viewport;

	public RectTransform rectLoading;

	[Header("Info")]
	public RawImage avatar;

	public UIRect_Profile_FrameAvatar rectFrameAvatar;

	public UIRect_Profile_Badge rectBadge;

	public Text txtName;

	public Text txtNamePremium;

	public RectTransform rectTeam;

	public Image avatarTeam;

	public Text txtTeam;

	public Button btnInfoTeam;

	[Header("Stats")]
	public TextMeshProUGUI txtDateModifier;

	public TextMeshProUGUI txtLevel;

	public TextMeshProUGUI txtFirstTryWins;

	public TextMeshProUGUI txtHelpsMade;

	public TextMeshProUGUI txtHelpsReceived;

	public TextMeshProUGUI txtAreasCompleted;

	public TextMeshProUGUI txtCollectionCompleted;

	public TextMeshProUGUI txtSetsCompleted;

	public TextMeshProUGUI txtID;

	public Button btnCopyID;

	public RectTransform rectTweenCopyID;

	[Header("Addon")]
	public UIPopup_ViewProfile_Friend_Addon friendAddon;

	public UIPopup_ViewProfile_Edit_Addon editAddon;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnRefresh_ViewProfile()
	{
	}

	private void OnSaveUIInfo()
	{
	}

	public static void OpenUI(int code)
	{
	}

	public void UpdateUI(int code)
	{
	}

	private void UpdateUI(UserInfoDetail data)
	{
	}

	private void ForceClosePopup()
	{
	}
}
