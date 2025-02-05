using System;

public class WinStreakDataController : NMSingleton<WinStreakDataController>
{
	private const string key = "winstreak";

	private WinStreakData _winStreak;

	public const int max_streak = 3;

	private bool _isShow;

	public static Action onUpdateWinStreak;

	public WinStreakData WinStreak => null;

	protected override void Init()
	{
	}

	private void InitData()
	{
	}

	public void SetDataToDefault()
	{
	}

	private void Save()
	{
	}

	public int GetLevelActive()
	{
		return 0;
	}

	public bool IsUnLock()
	{
		return false;
	}

	public bool IsShowTut()
	{
		return false;
	}

	public int GetTimeBonus(int streak)
	{
		return 0;
	}

	public int GetCurrentTimeBonus()
	{
		return 0;
	}

	public bool HasWinStreak()
	{
		return false;
	}

	public void CompleteLevel()
	{
	}

	public void Lose()
	{
	}

	private void ValidateData()
	{
	}

	public void UpdateDataFromServer(WinStreakData winStreak)
	{
	}
}
