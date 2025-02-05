using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UITopBarInfo_V2 : MonoBehaviour
{
	public RectTransform[] rectBGDiffs;

	public RectTransform txtCountDown;

	public RectTransform rectProgressCombo;

	[Header("Golden Gift")]
	public Image iconGoldenGift;

	public Image bgGoldenGift;

	public Sprite[] spritesGoldenGifts;

	[Header("Target")]
	public TextMeshProUGUI txtTarget;

	public DOTweenAnimation tweenTxtTarget;

	public RectTransform rectComplete;

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

	private void OnActiveMatch3Item(Vector2 vector)
	{
	}

	private void ActiveToastStuckInLayer()
	{
	}

	private void DeactiveStuckInLayer()
	{
	}

	private void UpdateUI_Target()
	{
	}
}
