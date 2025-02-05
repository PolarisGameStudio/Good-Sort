using UnityEngine;
using UnityEngine.UI;

public class UIEndGame : MonoBehaviour
{
	public static EndGameState s_EndGameState;

	public RectTransform rectPreCongratulation;

	public RectTransform rectCongratulation;

	public UISkeGraphicSequenceAnimation[] uiSkes;

	public Button btnTapClose;

	public UIPopup uiPopupShowcase;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void EndGame(EndGameState endGameState)
	{
	}

	private void UpdateUI_Congratulation()
	{
	}
}
