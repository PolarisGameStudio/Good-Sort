using UnityEngine;

public class UI_InGame_EventPVP_PreviewBar : MonoBehaviour
{
	[SerializeField]
	private RectTransform _rectTxtToastFinished;

	private Coroutine _coroutineShowToastStuck;

	private Coroutine _coroutine;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void ShowToastFinished()
	{
	}

	public void StopShowToastStuck(PowerupKind powerupKind)
	{
	}
}
