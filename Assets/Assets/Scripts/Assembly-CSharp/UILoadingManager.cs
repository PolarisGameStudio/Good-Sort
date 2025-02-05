using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UILoadingManager : MonoBehaviour
{
	[Serializable]
	public class Tween_InGame
	{

		public Image bgArt;

		public Sprite[] sprArtDiffs;

		public Image logo;

		public Material mCircleIn;

		public Material mCircleOut;

		private int key_m_circle_in;

		private int key_m_circle_out;

		public IEnumerator IEIn()
		{
			return null;
		}

		public IEnumerator IEOut()
		{
			return null;
		}
	}

	public static Action OnUILoadingInDone;

	public static Action onUILoadingDone;

	[Header("OutGame")]
	public RectTransform outgame;

	public Slider sliderProgress;

	[Header("InGame")]
	public RectTransform ingame;

	public Tween_InGame tween_InGame;

	public static bool s_IsSceneDone;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnChangeSceneState(SceneState state)
	{
	}

	private void OnLoadingScene(float percent)
	{
	}

	private void OnLoadingSceneDone(SceneState sceneState)
	{
	}

	private bool IsFirstLoading()
	{
		return false;
	}
}
