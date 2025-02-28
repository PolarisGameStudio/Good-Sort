using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIEndGame : Singleton<UIEndGame>
{
	public static EndGameState s_EndGameState;

	public RectTransform rectPreCongratulation;

	public RectTransform rectCongratulation;

	public RectTransform rectShowCase;

    public UISkeGraphicSequenceAnimation[] uiSkes;

	public Button btnTapClose;

	public UIPopup uiPopupShowcase;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void EndGame(EndGameState endGameState)
	{
		if(endGameState == EndGameState.Win)
		{
			StartCoroutine(GameWin());
        }
	}

	IEnumerator GameWin()
	{
        rectPreCongratulation.gameObject.SetActive(true);
		yield return new WaitForSeconds(1.0f);
        rectPreCongratulation.gameObject.SetActive(false);
        rectCongratulation.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        rectCongratulation.gameObject.SetActive(false);
        rectShowCase.gameObject.SetActive(true);
    }

    private void UpdateUI_Congratulation()
	{
	}
}
