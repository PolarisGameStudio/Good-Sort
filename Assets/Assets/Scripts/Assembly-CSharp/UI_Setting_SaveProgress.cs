using System;
using UnityEngine;
using UnityEngine.UI;

public class UI_Setting_SaveProgress : MonoBehaviour
{
	public static Action OnCloseUI;

	public RectTransform rectBG;

	public RectTransform rectDesNotSign;

	public RectTransform rectDesSigned;

	public RectTransform rectFacebook;

	public Button btnSignInFacebook;

	public Button btnSignOutFacebook;

	public RectTransform rectGoogle;

	public Button btnSignInGoogle;

	public Button btnSignOutGoogle;

	public RectTransform rectApple;

	public Button btnSignInApple;

	public Button btnSignOutApple;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnSignIn(BindDataType bindDataType)
	{
	}

	private void OnSignInFail(BindDataType bindDataType)
	{
	}

	private void UpdateUI()
	{
	}
}
