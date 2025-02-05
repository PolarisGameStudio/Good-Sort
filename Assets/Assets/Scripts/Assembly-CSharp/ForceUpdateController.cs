using UnityEngine;

public class ForceUpdateController : PersistentSingleton<ForceUpdateController>
{
	[SerializeField]
	private UIPopupForceUpdate _uiPopup;

	private int _type;

	private string _targetVersion;

	private bool _isLoadScene;

	public void InitPopup(UIPopup popup)
	{
	}

	private void CheckAndForceUpdate()
	{
	}

	public void OnForceUpdate(int type, string targetVersion)
	{
	}
}
