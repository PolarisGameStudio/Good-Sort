using UnityEngine;
using UnityEngine.UI;

public class UITopBarInfo : MonoBehaviour
{
	public Sprite[] bgTimes;

	public Image bgTime;

	public RectTransform txtCountDown;

	public Image iconGoldenGift;

	[Header("Stuck InGame")]
	public RectTransform rectToastStuck;

	private Coroutine coroutineStuck;

	private bool _isStuckInLayer;

	private void Awake()
	{
	}

	private void GenLevelDone()
	{
	}

	private void OnCellChangeLayer()
	{
	}

	private void OnStuckInLayer()
	{
	}

	private void OnActivePowerup(PowerupKind kind)
	{
	}

	private void ActiveToastStuckInLayer()
	{
	}

	private void DeactiveStuckInLayer()
	{
	}
}
