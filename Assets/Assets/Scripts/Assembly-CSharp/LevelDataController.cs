using System;
using System.Collections.Generic;

public class LevelDataController : NMSingleton<LevelDataController>
{
	private const string key_en = "level_en";

	private const string key_quit_level = "quit_level";

	private QuitLevelData _quitLevel;

	private LevelData _levelData;

	public static Action onPlay;

	public static Action onCompleteLevel;

	private const string key_max_level_server = "max_level_server";

	private int _maxLevelFromServer;

	private int _levelJustPassed;

	private bool _isPassedLevelMaxBefore;

	private const string key_level_max_random = "lv_m_r";

	public static Action onLose;

	public QuitLevelData QuitLevel => null;

	public LevelData LevelData => null;

	public int Level => 0;

	public int NumPlay => 0;

	public int MaxLevelFromServer => 0;

	public bool IsPassedLevelMaxBefore => false;

	protected override void Init()
	{
	}

	private void InitData()
	{
	}

	public void SetDataToDefault()
	{
	}

	private void SaveQuitLevel()
	{
	}

	public void CheckQuitLevel()
	{
	}

	public void ActiveQuitLevel(int duration, int wave, List<string> quitDetails)
	{
	}

	public void DeActiveQuitLevel()
	{
	}

	public void Save()
	{
	}

	public void Play()
	{
	}

	public int GetMaxLevel()
	{
		return 0;
	}

	public void CheckSetMaxLevelFromServer(int maxLevel)
	{
	}

	public int GetLevelJustPassed()
	{
		return 0;
	}

	public bool IsPassLevelMax()
	{
		return false;
	}

	public int GetLevelRandomWhenMaxLevel()
	{
		return 0;
	}

	public void GenNewLevelMax()
	{
	}

	private string GetKeyPassLevelMax()
	{
		return null;
	}

	public void Lose(bool isAddFailCount = false)
	{
	}

	public void CompleteLevel()
	{
	}

	public void UpdateDataFromServer(LevelDataServer levelData)
	{
	}

	public LevelDifficult GetLevelDifficult()
	{
		return default(LevelDifficult);
	}

	public LevelDifficult GetLevelDifficult(int level)
	{
		return default(LevelDifficult);
	}

	private int GetNumFailApplyFailSafe(int level)
	{
		return 0;
	}

	public bool IsApplyFailSafe()
	{
		return false;
	}
}
