using System;
using UnityEngine;

public class ComboInGameController : Singleton<ComboInGameController>
{
	private int _star;

	private int _currentCombo;

	private float _currentTime;

	private float _maxTime;

	private int _countComboData;

	private bool _x2Reward;

	private bool _isWinGame;

	public Action onUpdateTime;

	public Action onResetCombo;

	public Action<Vector2, int> onActiveCombo;

	public int Star => 0;

	public int CurrentCombo => 0;

	public float CurrentTime => 0f;

	public float MaxTime => 0f;

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void EndGame(EndGameState state)
	{
	}

	private void ActiveCombo(Vector2 pos)
	{
	}

	private void PlaySoundCombo(int combo)
	{
	}

	public int GetStarInCurrentCombo()
	{
		return 0;
	}

	private void ResetCombo()
	{
	}

	public float GetRatioTime()
	{
		return 0f;
	}

	private void Update()
	{
	}
}
