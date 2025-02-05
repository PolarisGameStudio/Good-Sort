using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class UI_InGame_EventPVP_PowerUpBar : MonoBehaviour
{
	[SerializeField]
	private List<UI_InGame_EventPVP_PowerUpBar_Item> _items;

	[SerializeField]
	private RectTransform _rectTxtToast;

	[SerializeField]
	private TextMeshProUGUI _txtToast;

	private Tween _tween;

	private Coroutine _coroutine;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void UpdateUIItems()
	{
	}

	private void VisualActivePowerUp(PowerupKind powerupKind)
	{
	}

	public void ShowToast(string content)
	{
	}
}
