using System;
using Falcon.FalconAnalytics.Scripts.Enum;

namespace Falcon.FalconAnalytics.Scripts.Controllers.Interfaces
{
	public interface ILog
	{
		void ActionLog(string actionName);

		void AdsLog(int maxPassedLevel, AdType type, string adWhere);

		void AdsLog(AdType type, string adWhere);

		void AdsLog(AdType type, string adWhere, string adPrecision, string adCountry, double adRev, string adNetwork, string adMediation);

		void FunnelLog(int maxPassedLevel, string funnelName, string action, int priority);

		void FunnelLog(string funnelName, string action, int priority);

		void InAppLog(string productId, string currencyCode, decimal localPrice, string transactionId, string purchaseToken, string where);

		[Obsolete("Must ensure duration is in second, use LevelLog(int level, TimeSpan duration, int wave, string difficulty, LevelStatus status) instead")]
		void LevelLog(int level, int duration, int wave, string difficulty, LevelStatus status);

		void LevelLog(int level, TimeSpan duration, int wave, string difficulty, LevelStatus status);

		void PropertyLog(int maxPassedLevel, string name, string value, int priority);

		void PropertyLog(string name, string value, int priority);

		void ResourceLog(int maxPassedLevel, FlowType flowType, string itemType, string itemId, string currency, long amount);

		void ResourceLog(FlowType flowType, string itemType, string itemId, string currency, long amount);

		[Obsolete("Must ensure sessionTime is in second, use SessionLog(int maxPassedLevel, TimeSpan sessionTime, string gameMode) instead")]
		void SessionLog(int maxPassedLevel, int sessionTime, string gameMode);

		[Obsolete("Must ensure sessionTime is in second, use SessionLog(int maxPassedLevel, TimeSpan sessionTime, string gameMode) instead")]
		void SessionLog(int sessionTime, string gameMode);

		void SessionLog(int maxPassedLevel, TimeSpan sessionTime, string gameMode);

		void SessionLog(TimeSpan sessionTime, string gameMode);
	}
}
