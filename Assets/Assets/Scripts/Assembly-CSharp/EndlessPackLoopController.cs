using System;

public class EndlessPackLoopController : NMSingleton<EndlessPackLoopController>
{
	private const int level_unlock = 30;

	private const string key = "endless_loop";

	private EndlessPackLoop _loopData;

	public Action onNextSeason;

	public static int dayOfWeek => 0;

	public static DayOfWeek dayOfWeekToNextEndless2 => default(DayOfWeek);

	public EndlessPackLoop LoopData => null;

	protected override void Init()
	{
	}

	public void SetDataToDefault()
	{
	}

	private void OnSceneChange(SceneState state)
	{
	}

	private void Save()
	{
	}

	private void CheckAndStartTime()
	{
	}

	public bool IsUnLock()
	{
		return false;
	}

	public TimeSpan GetTimeSpan()
	{
		return default(TimeSpan);
	}

	public bool IsEnd()
	{
		return false;
	}

	public void NextSeasion()
	{
	}

	public int GetEndlessType()
	{
		return 0;
	}

	private DateTime GetTimeEnd()
	{
		return default(DateTime);
	}

	public void UpdateDataFromServer(EndlessPackLoop endlessPackLoop)
	{
	}
}
