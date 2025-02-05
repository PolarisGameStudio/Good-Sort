using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Noti : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI _textTitle;

	[SerializeField]
	private Text _textContent;

	[SerializeField]
	private Button[] _btnAccept;

	[SerializeField]
	private Button[] _btnCancel;

	[SerializeField]
	private GameObject[] _buttonContainers;

	public void ShowPopupNoti(string title, string content, bool canClose, Action accept, Action close)
	{
	}

	public void UpdateData(SCPopupData scPopupData)
	{
	}
}
