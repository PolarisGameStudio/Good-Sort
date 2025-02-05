using UnityEngine;
using UnityEngine.UI;

public class UILeaderboard_Friends : MonoBehaviour
{
	public RectTransform[] tabs;

	[Header("Connect Facebook")]
	public RectTransform rectFacebook;

	public RectTransform rectBanner;

	public Button btnFacebook;

	[Header("Ref")]
	public UILeaderboard_NavType refNavType;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnSignIn(BindDataType type)
	{
	}

	private void OnSignOut()
	{
	}

	private void UpdateUI_ConnectFacebook()
	{
	}

	private void UpdateUI_StateRectBannerFacebook()
	{
	}
}
