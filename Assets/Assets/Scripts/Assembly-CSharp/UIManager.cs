using System;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
	[Tooltip("All the menus in the scene.")]
	public List<UIMenu> AllMenus;

	[HideInInspector]
	public UIMenu CurActiveMenu;

	[Tooltip("All the popups in the scene.")]
	public List<UIPopup> AllPopups;

	[HideInInspector]
	public UIPopup CurActivePopup;

	[Header("Store - UIPopup")]
	public RectTransform rootStorePopup;

	private bool canEsc;

	private List<UIPopup> stack;

	public Dictionary<string, Action<UIPopup>> dicActionOnOpenPopup;

	public static Action OnUIPopupChange;

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void UnLoadAsset()
	{
	}

	public void LoadSceneAdditive(string name)
	{
	}

	private UIMenu GetCurrentMenu()
	{
		return null;
	}

	public void OpenMenu_Stack(string menuName)
	{
	}

	public void OpenMenu(string menuName)
	{
	}

	public void OpenMenu(UIMenu menu)
	{
	}

	public void NextMenu()
	{
	}

	public void OpenPopup(string popupName, Action<UIPopup> callback = null)
	{
	}

	public void OpenPopup(UIPopup popup, Action<UIPopup> callback = null)
	{
	}

	public void OpenPopupIE(UIPopup popup, Action onShow)
	{
	}

	public void ClosePopup()
	{
	}

	public void ClosePopup(string popupName)
	{
	}

	public void ClosePopup(UIPopup popup)
	{
	}

	public void CloseAllPopup()
	{
	}

	private void RegisterPopupStack(UIPopup popup)
	{
	}

	private UIPopup GetTopMostPopupStack()
	{
		return null;
	}

	private void StateActivatePopupStack(bool isOpenPopup)
	{
	}

	public List<UIPopup> GetAllPopupStack()
	{
		return null;
	}

	public int GetNumPopupStack()
	{
		return 0;
	}

	public bool IsFreeUI_PopupFullScreen()
	{
		return false;
	}

	public bool IsFreeUI_PopupHalfFullScreen()
	{
		return false;
	}

	public void OpenUI(string nameUI)
	{
	}

	public void StateEsc(bool isOn)
	{
	}
}
