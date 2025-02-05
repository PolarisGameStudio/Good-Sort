using System;

public interface INoti
{
	bool CanNoti();

	void ScheduleNoti(string title, string content, DateTime dateTime);

	void ClearNoti();
}
