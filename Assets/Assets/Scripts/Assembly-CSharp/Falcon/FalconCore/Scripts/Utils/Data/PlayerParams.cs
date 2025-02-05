using System;

namespace Falcon.FalconCore.Scripts.Utils.Data
{
	[Obsolete("Use FPlayerInfoRepo instead")]
	public static class PlayerParams
	{
		public static string AccountID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string AbTestingVariable => null;

		public static string AbTestingValue => null;

		public static DateTime FirstLoginDate => default(DateTime);

		public static int MaxPassedLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int InterstitialAdCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int RewardAdCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int SessionId => 0;
	}
}
