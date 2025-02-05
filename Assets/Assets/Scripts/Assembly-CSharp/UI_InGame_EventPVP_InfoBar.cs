using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_InGame_EventPVP_InfoBar : MonoBehaviour
{
	private DOTweenAnimation _tweenInfoPlayer;

	private DOTweenAnimation _tweenInfoOpponent;

	[SerializeField]
	private UI_InGame_EventPVP_InfoBar_InfoPanel _infoPlayer;

	[SerializeField]
	private UI_InGame_EventPVP_InfoBar_InfoPanel _infoOpponent;

	[SerializeField]
	private RectTransform _panelTime;

	[SerializeField]
	private RectTransform _panelTimeDefault;

	[SerializeField]
	private RectTransform _panelTimeRust;

	[SerializeField]
	private TextMeshProUGUI[] _timeTexts;

	[SerializeField]
	private Button _btnExit;

	[SerializeField]
	private UI_InGame_EventPVP_Home_PoolFly_Damage _poolDamage;

	private int _cachePlayerHp;

	private bool _isChangedUI;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private void UpdateDefaultStartLevel()
	{
	}

	private void UpdateUIProfile()
	{
	}

	private void UpdateUIHealthsDefault()
	{
	}

	private void UpdateUIHealth()
	{
	}

	private void CheckVisualHitPlayer()
	{
	}

	private void VisualHitPlayer()
	{
	}

	private void VisualHitEnemy(Vector2 pos)
	{
	}

	private void PoolDamage(Vector2 posSpawn, Vector2 posTarget, Action onDamaged)
	{
	}

	private void UpdateUITime()
	{
	}

	private void UpdateUIPanelTime()
	{
	}

	private string GetFormatTimeDefault()
	{
		return null;
	}

	private void DisplayTime(double timeToDisplay)
	{
	}

	private void OnEndGame(EndGameState state)
	{
	}
}
