using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Digging_Notify : MonoBehaviour
{
	public UITimerCountdownTMP uITimerCountdown;

	public TextMeshProUGUI txtDes;

	public DOTweenAnimation tweenBG;

	public RectTransform rectViewport;

	public Button btnExit;

	public Button btnGo;

	public Button btnJoinEvent;

	private bool IsIntroTween;

	private void OnEnable()
	{
	}

	private void UpdateUI()
	{
	}

	private void StateButton(bool state)
	{
	}

	private void CloseThisPopup(bool isOpenEvent)
	{
	}
}
