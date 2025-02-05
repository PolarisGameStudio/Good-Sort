using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : NMSingleton<SceneController>
{

	private SceneState _preSceneState;

	private SceneState _currentSceneState;

	public Action<SceneState> onChangeSceneState;

	private AsyncOperation asyncScene;

	public Action<float> onLoadingScene;

	public Action<SceneState> onLoadingSceneDone;

	public const float MAX_TIME_WAIT_ANIMATION_LOADING = 1f;

	private bool _isLoading;

	public SceneState PreSceneState => default(SceneState);

	public SceneState CurrentSceneState => default(SceneState);

	protected override void Init()
	{
	}

	private bool SetSceneState(SceneState sceneState)
	{
		return false;
	}

	public void LoadMenu()
	{
	}

	public void LoadLevel()
	{
	}

	public void LoadPVP()
	{
	}

	public void LoadPreview()
	{
	}

	public bool IsFirstLoading()
	{
		return false;
	}

	private IEnumerator CoroutineLoadScene(SceneState sceneState, string sceneName)
	{
		return null;
	}

	private void ForceDataFromServer()
	{
	}

	public void LoadScene(string name, LoadSceneMode mode = LoadSceneMode.Single)
	{
	}

	public AsyncOperation LoadSceneAsync(string name, LoadSceneMode mode = LoadSceneMode.Single)
	{
		return null;
	}

	public AsyncOperation LoadSceneAsync(int index, LoadSceneMode mode = LoadSceneMode.Single)
	{
		return null;
	}

	public void UnloadSceneAsync(int index, Action callback)
	{
	}

	public void UnloadSceneAsync(string name, Action callback)
	{
	}
}
