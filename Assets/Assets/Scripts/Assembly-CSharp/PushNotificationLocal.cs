using System;

[Serializable]
public class PushNotificationLocal
{
	public int day;

	public int hour;

	public int minute;

	public string title;

	public string content;

	public PushNotificationLocal(int day, int hour, int minute, string title, string content)
	{
	}
}
