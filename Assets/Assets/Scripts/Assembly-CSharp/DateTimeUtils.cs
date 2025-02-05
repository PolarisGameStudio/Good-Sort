using System;

public static class DateTimeUtils
{
	public static readonly DateTime BASE_DATE;

	private static DateTime start;

	public static DateTime Now => default(DateTime);

	public static DateTime UtcNow => default(DateTime);

	public static DateTime NextDay()
	{
		return default(DateTime);
	}

	public static DateTime NextWeek(DateTime date)
	{
		return default(DateTime);
	}

	public static bool IsLastWeek(DateTime dateTime)
	{
		return false;
	}

	public static bool IsLastWeekUTC(DateTime dateTime)
	{
		return false;
	}

	public static DateTime ResetTimeTo0H(DateTime dateTime)
	{
		return default(DateTime);
	}

	public static DateTime GetDateTimeFromMiniSecond(long miniSecond)
	{
		return default(DateTime);
	}

	public static DateTime GetDateTimeFromTick(long ticks)
	{
		return default(DateTime);
	}

	public static TimeSpan GetTimeSpanFromNowToNextTime(long nextTime)
	{
		return default(TimeSpan);
	}

	public static TimeSpan GetTimeSpanFromNowToNextTime(DateTime nextTime)
	{
		return default(TimeSpan);
	}

	public static TimeSpan GetTimeSpanFromTimeToNextTime(long time, long nextTime)
	{
		return default(TimeSpan);
	}

	public static TimeSpan GetTimeSpanFromTimeToNextTime(DateTime time, DateTime nextTime)
	{
		return default(TimeSpan);
	}

	public static DateTime GetNextDay()
	{
		return default(DateTime);
	}

	public static DateTime GetNextDay(DateTime date)
	{
		return default(DateTime);
	}

	public static DateTime Get8HUtcToday()
	{
		return default(DateTime);
	}

	public static DateTime GetNextWeek(DateTime date)
	{
		return default(DateTime);
	}

	public static DateTime GetMondayOfWeek(DateTime date)
	{
		return default(DateTime);
	}

	public static DateTime GetNextMonth(DateTime date)
	{
		return default(DateTime);
	}

	public static TimeSpan GetTimeSpanFromMiliSecond(long miliseconds)
	{
		return default(TimeSpan);
	}

	public static TimeSpan GetTimeSpanFromSecond(long seconds)
	{
		return default(TimeSpan);
	}

	public static long GetMiliSecondFromTimeSpan(TimeSpan timeSpan)
	{
		return 0L;
	}

	public static long GetMiliSecondFromDateTime(DateTime datetime)
	{
		return 0L;
	}

	public static long GetMiliSecondFromDateTimeNow()
	{
		return 0L;
	}

	public static long GetMiliSecondFromDateTimeUtcNow()
	{
		return 0L;
	}

	public static DateTime GetDateTimeFromMiliSecond(double miliseconds)
	{
		return default(DateTime);
	}

	public static bool IsDatesInSameWeek(DateTime preDate, DateTime currentDate)
	{
		return false;
	}

	public static bool IsSameDay(long time1, long time2)
	{
		return false;
	}

	public static bool IsSameDay(DateTime dateTime1, DateTime dateTime2)
	{
		return false;
	}

	public static int CompareDay(long time1, long time2)
	{
		return 0;
	}

	public static int CompareDay(DateTime dateTime1, DateTime dateTime2)
	{
		return 0;
	}

	public static int GetNumDayFromBaseTime(DateTime dateTime)
	{
		return 0;
	}

	public static int GetNumDayFrombaseTime(int year)
	{
		return 0;
	}

	public static string GetTimespanInThePassFromNow(long time)
	{
		return null;
	}

	public static string GetTimespanInThePassFromNow(DateTime dateTime)
	{
		return null;
	}

	public static string GetTimeMonthYear(long time)
	{
		return null;
	}

	public static DateTime GetDateTimeForDayOfWeek(DayOfWeek dayOfWeek)
	{
		return default(DateTime);
	}
}
