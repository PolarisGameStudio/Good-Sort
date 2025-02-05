using System;

public class AudioDataController : NMSingleton<AudioDataController>
{
	private const string key = "audio";

	private TurnOnOffAudio _turnOnOffAudio;

	public Action onChange;

	public Action onChangeMusic;

	protected override void Init()
	{
	}

	private void InitData()
	{
	}

	private void Save()
	{
	}

	public void SetMusic(int state)
	{
	}

	public void SetSound(int state)
	{
	}

	public bool IsActiveMusic()
	{
		return false;
	}

	public bool IsActiveSound()
	{
		return false;
	}
}
