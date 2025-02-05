using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Digging_ConfirmExit : MonoBehaviour
{
	public UITimerCountdownTMP timer;

	public Button btnQuit;

	public Button btnContinue;

	public TextMeshProUGUI txtCurrentAxe;

	public void UpdateUI(Action OnClickQuit)
	{
	}
}
