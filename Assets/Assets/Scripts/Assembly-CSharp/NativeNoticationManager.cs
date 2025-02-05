using System;

public class NativeNoticationManager : Singleton<NativeNoticationManager>
{
	private INoti _noti;

	private bool _isScheduled;

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	public void ScheduleNoti(string title, string content, DateTime dateTime)
	{
	}

	private void ClearNoti()
	{
	}

	public bool CanNoti()
	{
		return false;
	}

	public void ScheduleNoti()
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}
}
