using Falcon.PuzzleCore.Team;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Clan_TeamInfo_Edit : MonoBehaviour
{
	public Image avatar;

	public Button btnOpenAvatar;

	public UIPopup popupAvatar;

	public InputField inputName;

	public InputField inputDes;

	public TextMeshProUGUI txtType;

	public Button[] btnTypes;

	public TextMeshProUGUI txtRequireLevel;

	public Button[] btnRequireLevels;

	public InputField inputRequireLevel;

	public Button btnSave;

	public RectTransform rectLoading;

	private int c_avatar;

	private int c_type;

	private int c_requireLevel;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEditTeamInfo(int status)
	{
	}

	public void UpdateUI(TeamInfo data)
	{
	}

	private void ChangeAvatar(int index)
	{
	}

	private void ChangeType()
	{
	}

	private void ChangeRequireLevel()
	{
	}
}
