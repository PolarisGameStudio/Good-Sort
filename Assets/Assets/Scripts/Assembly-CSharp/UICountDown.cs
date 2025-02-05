using TMPro;
using UnityEngine;

public class UICountDown : Singleton<UICountDown>
{
	public TextMeshProUGUI _textTime;

	public RectTransform rectFreezeActive;

	public ParticleSystem _fx;

	public ParticleSystem _fxFreezeTimeBox;

	private int _time;

	public ParticleSystem _fxwarning;

	protected override void Awake()
	{
	}

	private void OnActivePowerup(PowerupKind kind)
	{
	}

	public void IncreaseTime(int timeIncrease)
	{
	}

	private void Update()
	{
	}
}
