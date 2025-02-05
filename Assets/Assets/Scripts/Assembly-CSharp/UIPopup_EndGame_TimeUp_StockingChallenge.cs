using UnityEngine;
using UnityEngine.UI;

public class UIPopup_EndGame_TimeUp_StockingChallenge : MonoBehaviour
{
	public UIPopup_EndGame_TimeUp refManager;

	public UIPanel_EndGame_TimeUp_GetMore getmore;

	public Button btnExit;

	public RectTransform rectBGProgressIdle;

	public RectTransform[] rectBGProgressMoves;

	public RectTransform rectMaskFollowTarget;

	public Slider sliderWinStreak;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}
}
