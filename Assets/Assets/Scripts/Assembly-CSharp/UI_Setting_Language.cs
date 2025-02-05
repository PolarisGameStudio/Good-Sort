using System;
using UnityEngine;
using UnityEngine.UI;

public class UI_Setting_Language : MonoBehaviour
{
	public static string s_NameI2Select;

	public static Action OnChangeI2;

	public ScrollRect scrollRect;

	public UI_Setting_Language_Item[] items;

	public Button btnContinue;

	public static void OnChangeLanguage(string name)
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	public static string GetNameLanguage(string nameI2)
	{
		return null;
	}
}
