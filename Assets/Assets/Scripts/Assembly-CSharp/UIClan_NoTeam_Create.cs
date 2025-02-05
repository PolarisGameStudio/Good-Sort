using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIClan_NoTeam_Create : MonoBehaviour
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

	public Button btnCreate;

	public TextMeshProUGUI txtCreate;

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

	private void OnCreateTeam(int status)
	{
	}

	private void UpdateUI()
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
