using UnityEngine;

public class UI_InGame_EventPVP_EndGame : MonoBehaviour
{
	public static EndGameState s_EndGameState;

	public RectTransform rectPreCongratulation;

	public RectTransform rectCongratulation;

	public RectTransform rectTxtToast;

	private Coroutine _coroutineShowToastStuck;

	private Coroutine _coroutine;

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

	public void ShowToastStuck()
	{
	}

	public void StopShowToastStuck(PowerupKind powerupKind)
	{
	}
}
