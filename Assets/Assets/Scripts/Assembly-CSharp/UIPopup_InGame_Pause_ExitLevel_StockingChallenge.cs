using UnityEngine;
using UnityEngine.UI;

public class UIPopup_InGame_Pause_ExitLevel_StockingChallenge : MonoBehaviour
{
	public UIPopup_InGame_Pause_ExitLevel refManager;

	public Button btnClosePopup;

	public Button btnQuit;

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
