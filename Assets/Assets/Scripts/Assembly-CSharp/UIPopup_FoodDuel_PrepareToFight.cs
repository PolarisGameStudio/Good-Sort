using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_FoodDuel_PrepareToFight : MonoBehaviour
{
	[Serializable]
	public class UserInfoPrepare
	{
		public Image avatar;

		public UIRect_Profile_FrameAvatar rectFrame;

		public Text txtName;

		public Text txtNamePremium;

		public TextMeshProUGUI txtMedal;
	}

	public Button btnExit;

	public UIPanel_TimeOutLoading rectLockUI;

	public TextMeshProUGUI txtStatusMatch;

	public RectTransform rectInforPrepareFinding;

	public RectTransform rectInforPrepareOpponent;

	public UserInfoPrepare userInfoPrepareMine;

	public UserInfoPrepare userInfoPrepareOpponent;

	private int _truncateNameLength;

	private string _truncateNameLengthWithDots;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEventPVPFoundMatch()
	{
	}

	private void OnEventPVPCancelFindMatch()
	{
	}

	private void UpdateUI()
	{
	}

	private string TruncateName(string name, int maxLength, string truncationSuffix)
	{
		return null;
	}
}
