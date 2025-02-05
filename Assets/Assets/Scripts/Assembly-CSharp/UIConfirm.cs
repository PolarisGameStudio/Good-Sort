using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIConfirm : Singleton<UIConfirm>
{
	public GameObject container;

	public Button button;

	public Button buttonCancel;

	public TextMeshProUGUI text;

	private void Start()
	{
	}

	public void ShowConfirm(Action action, string content)
	{
	}
}
