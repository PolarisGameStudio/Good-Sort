namespace Ugi.PlayInstallReferrerPlugin
{
	public class PlayInstallReferrerDetails
	{
		public string InstallReferrer { get; }

		public long? ReferrerClickTimestampSeconds { get; }

		public long? InstallBeginTimestampSeconds { get; }

		public bool? GooglePlayInstant { get; }

		public PlayInstallReferrerError Error { get; }

		internal PlayInstallReferrerDetails(string installReferrer, long referrerClickTimestampSeconds, long installBeginTimestampSeconds, bool googlePlayInstant)
		{
		}

		internal PlayInstallReferrerDetails(PlayInstallReferrerError error)
		{
		}
	}
}
