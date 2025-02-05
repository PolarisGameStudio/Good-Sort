using System;
using Falcon.FalconAnalytics.Scripts.Controllers.Interfaces;
using Falcon.FalconAnalytics.Scripts.Enum;
using Falcon.FalconCore.Scripts.Utils.Singletons;

namespace Falcon
{
	[Obsolete("We do new FLog().Send() now")]
	public class DWHLog : FSingleton<DWHLog>, ILog
	{
		public static ILog Log => null;

		public void ActionLog(string actionName)
		{
		}

		public void AdsLog(int maxPassedLevel, AdType type, string adWhere)
		{
		}

		public void AdsLog(AdType type, string adWhere)
		{
		}

		public void AdsLog(AdType type, string adWhere, string adPrecision, string adCountry, double adRev, string adNetwork, string adMediation)
		{
		}

		public void FunnelLog(int maxPassedLevel, string funnelName, string action, int priority)
		{
		}

		public void FunnelLog(string funnelName, string action, int priority)
		{
		}

		public void InAppLog(string productId, string currencyCode, decimal localPrice, string transactionId, string purchaseToken, string where)
		{
		}

		public void LevelLog(int level, int duration, int wave, string difficulty, LevelStatus status)
		{
		}

		public void LevelLog(int level, TimeSpan duration, int wave, string difficulty, LevelStatus status)
		{
		}

		public void PropertyLog(int maxPassedLevel, string name, string value, int priority)
		{
		}

		public void PropertyLog(string name, string value, int priority)
		{
		}

		public void ResourceLog(int maxPassedLevel, FlowType flowType, string itemType, string itemId, string currency, long amount)
		{
		}

		public void ResourceLog(FlowType flowType, string itemType, string itemId, string currency, long amount)
		{
		}

		public void SessionLog(int maxPassedLevel, int sessionTime, string gameMode)
		{
		}

		public void SessionLog(int sessionTime, string gameMode)
		{
		}

		public void SessionLog(int maxPassedLevel, TimeSpan sessionTime, string gameMode)
		{
		}

		public void SessionLog(TimeSpan sessionTime, string gameMode)
		{
		}
	}
}
