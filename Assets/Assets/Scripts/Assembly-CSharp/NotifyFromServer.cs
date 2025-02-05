using System;

public class NotifyFromServer : PersistentSingleton<NotifyFromServer>
{
	private UIPopup_Noti _uiPopup;

	public Action<SCPopupData> onGetNotiFromServer;

	private bool _isLoadScene;

	public void GetNotiFromServer(SCPopupData scPopupData)
	{
	}

	public void InitPopup(UIPopup popup, SCPopupData sCPopupData)
	{
	}

	private void UpdateData(SCPopupData sCPopupData)
	{
	}

	public void OnForceUpdate(SCPopupData scPopupData)
	{
	}
}
