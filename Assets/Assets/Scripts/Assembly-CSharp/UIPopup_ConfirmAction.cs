using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_ConfirmAction : MonoBehaviour
{
	public TextMeshProUGUI txtTitle;

	public Text txtContent;

	public Button btnYes;

	public Button btnNo;

	public RectTransform rectWarning;

	public Text txtContentWarning;

	private void Start()
	{
	}

	public void UpdateUI(string strTitle, string strContent, Action onClickYes)
	{
	}

	public void UpdateUI_Warning(string strTitleWarning)
	{
	}
}
