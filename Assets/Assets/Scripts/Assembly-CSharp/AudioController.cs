using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class AudioController : Singleton<AudioController>
{
	[SerializeField]
	private AudioSource _bgMusic;

	[SerializeField]
	private AudioClip[] _bgMusics;

	[SerializeField]
	private Sound[] _sounds;

	private Dictionary<SoundKind, Sound> _soundContainer;

	[SerializeField]
	private Sound[] _soundMatch3_0;

	private Tween _tween;

	public void Validate()
	{
	}

	public void GetIndex(SoundKind soundKind)
	{
	}

	protected override void Awake()
	{
	}

	private void OnChangeScene(SceneState state)
	{
	}

	private void OnChange()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void EndGame(EndGameState state)
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	public void PlayMusic()
	{
	}

	public void StopMusic()
	{
	}

	public static void PlaySound(SoundKind kind)
	{
	}

	public static void PlaySound(SoundKind kind, float volume)
	{
	}

	public static void PlaySoundMatch3(int combo)
	{
	}

	public static void Stop(SoundKind kind)
	{
	}
}
