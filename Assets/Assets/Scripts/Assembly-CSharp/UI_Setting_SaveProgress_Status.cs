using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Setting_SaveProgress_Status : MonoBehaviour
{
	public TextMeshProUGUI txtTitle;

	public RectTransform rectFacebook;

	public RectTransform rectFacebookSuccess;

	public RectTransform rectFacebookFail;

	public RectTransform rectGoogle;

	public RectTransform rectGoogleSuccess;

	public RectTransform rectGoogleFail;

	public RectTransform rectApple;

	public RectTransform rectAppleSuccess;

	public RectTransform rectAppleFail;

	public RectTransform rectBtnContinue;

	public RectTransform rectBtnTryAgain;

	public Button btnContinue;

	public Button btnTryAgain;

	public void UpdateUI(bool isSuccess, BindDataType bindDataType, Action onClick)
	{
	}
}
