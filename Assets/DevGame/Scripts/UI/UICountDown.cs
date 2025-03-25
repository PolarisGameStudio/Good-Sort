using Spine.Unity;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UICountDown : Singleton<UICountDown>
{
	public TextMeshProUGUI _textTime;

	public RectTransform rectFreezeActive;

	public ParticleSystem _fx;

	public ParticleSystem _fxFreezeTimeBox;

	private int _time;

	public ParticleSystem _fxwarning;
	public SkeletonGraphic _spClock;

	private bool isPlayingAnimation = false;

	protected override void Awake()
	{
	}

	private void OnActivePowerup(PowerupKind kind)
    {
    }
    public void PlayAnimationClock()
	{
		if(isPlayingAnimation)
		{
			return;
		}
        isPlayingAnimation = true;
        _spClock.timeScale = 1;
        _spClock.AnimationState.SetAnimation(0, "animation", true);
    }

    public void OnPauseAnimationClock()
    {
        if (!isPlayingAnimation)
        {
            return;
        }
        isPlayingAnimation = false;
        _spClock.timeScale = 0;
    }

    public void IncreaseTime(int timeIncrease)
	{
		_fx.Play();

    }

	public void OnActiveAnimWarning(bool isActive)
	{
		if(isActive)
		{
            _fxwarning.Play();
		}
		else
		{
			_fxwarning.Stop();
        }
    }	

	private void Update()
	{
	}
}
