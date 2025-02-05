using System;
using System.Collections.Generic;
using UnityEngine;

public class RecommenPowerup : MonoBehaviour
{
	private List<PowerupKind> _listPowerupUnlocked;

	private List<PowerupKind> _listPowerupCanRecommand;

	private int _timeToRecommand1;

	private int _timeToRecommand2;

	private int _timeToRecommand;

	private float _timeNoMove;

	private bool _hasPowerup;

	public Action<PowerupKind> onRecommend;

	public Action onDisableRecommend;

	public Action onCloseToast;

	private List<PowerupKind> _powerups;

	private PowerupKind? _currentPowerup;

	private void Awake()
	{
	}

	private void EndGame(EndGameState state)
	{
	}

	private void InitPowerup()
	{
	}

	private void TimeWarning(bool obj)
	{
	}

	private void RecommendFreeze()
	{
	}

	private void OnDestroy()
	{
	}

	private void ActiveMatch3(Vector2 vector)
	{
	}

	private void UpdateListPowerupCanRecommand()
	{
	}

	private void ActivePowerup(PowerupKind kind)
	{
	}

	private void OnMove()
	{
	}

	private void Update()
	{
	}

	private PowerupKind GetPowerUpToRecommand()
	{
		return default(PowerupKind);
	}

	public void Recommend(PowerupKind powerupKind)
	{
	}

	public void CloseToast()
	{
	}

	public void DisableRecommand()
	{
	}
}
