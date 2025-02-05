using System;
using System.Collections.Generic;

public class PushNotification : SingletonDontDestroy<PushNotification>
{
	private const string KEY_PUSH_LOCAL = "push_local_noti";

	private const string CHANEL_ID = "hex_sort";

	private const string GROUP_NAME = "Hex Sort";

	public List<PushNotificationLocal> pushLocals;

	private void Start()
	{
	}

	private void AutoPush()
	{
	}

	public void ClearAllPush()
	{
	}

	public void PushFromServer(List<PushSchedule> push_schedules)
	{
	}

	private void Init()
	{
	}

	private int CreateAndroidNotification(string title, string content, DateTime targetTime)
	{
		return 0;
	}

	private void CreateIOSNotification(string id, string title, string content, DateTime targetTime)
	{
	}
}
