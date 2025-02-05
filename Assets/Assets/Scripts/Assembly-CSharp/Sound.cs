using System;
using UnityEngine;

[Serializable]
public class Sound
{
	public SoundKind soundKind;

	public int num;

	[Range(0f, 1f)]
	public float volume;

	public AudioClip clip;

	private AudioSource[] sources;

	public void Init(Transform parent)
	{
	}

	public void Play()
	{
	}

	public void Play(float volume)
	{
	}

	public void Stop()
	{
	}
}
