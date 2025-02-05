using System;
using System.Collections.Generic;
using ScrollSnapExtension;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Profile : MonoBehaviour
{
	public static Action onSaveUI;

	public static int s_SelectIdAvatar;

	public static int s_SelectIdFrameAvatar;

	public static int s_SelectIdBadge;

	private static Action s_OnSelectIdAvatar;

	private static Action s_OnSelectFrameAvatar;

	private static Action s_OnSelectIdBadge;

	[Header("Tab")]
	public Button[] btnSelectTabs;

	public RectTransform[] rectBtnSelectActives;

	public RectTransform[] rectBtnSelectDeactives;

	public RectTransform[] rectTextBtnSelectActives;

	public RectTransform[] rectTextBtnSelectDeactives;

	public RectTransform[] tabs;

	public Button btnSave;

	[Header("Profile")]
	[SerializeField]
	private RawImage _avatar;

	[SerializeField]
	private UIRect_Profile_FrameAvatar rectFrameAvatar;

	[SerializeField]
	private UIRect_Profile_Badge rectBadge;

	[SerializeField]
	private InputField _inputField;

	public Text txtNamePremium;

	[SerializeField]
	[Header("Scroll Rect Avatar")]
	private ScrollRectEnsureVisible _scroll;

	[SerializeField]
	private AvatarSelect _avatarSelectPrefab;

	[SerializeField]
	private GameObject _avatarContainer;

	public Button btnFacebook;

	[Header("Scroll Rect Frame Avatar")]
	public RectTransform rectContentScrollFrame;

	public List<UIPopup_Profile_SelectFrameAvatar_Item> itemFrameAvatars;

	[Header("Scroll Badge")]
	public RectTransform rectContentScrollBadge;

	public List<UIPopup_Profile_SelectBadge_Item> itemBadges;

	public UIPopup uiPopupBadgeConfirm;

	private List<AvatarSelect> _avatarSelects;

	private AvatarSelect _avatarSpecialSelect;

	public static void SelectIdAvatar(int id)
	{
	}

	public static void SelectIdFrameAvatar(int id)
	{
	}

	public static void SelectIdBadge(int id)
	{
	}

	public static bool IsChangeData()
	{
		return false;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnSignIn(BindDataType type)
	{
	}

	private void UPdateCache()
	{
	}

	private void OnDisable()
	{
	}

	private void UpdateAvatar()
	{
	}

	private void UpdateFrameAvatar()
	{
	}

	private void UpdateBadge()
	{
	}
}
