using System;
using Falcon.FalconAnalytics.Scripts.Enum;
using Falcon.FalconAnalytics.Scripts.Models.Messages.PreDefines;
using UnityEngine.Scripting;

[Serializable]
public class FResourceLogNew : FResourceLog
{
	public long value_before;

	public long value_after;

	[Preserve]
	public FResourceLogNew()
	{
	}

	public FResourceLogNew(FlowType flowType, string itemType, string currency, string itemId, long amount, long valueBefore, long valueAfter, int currentLevel = 0)
	{
	}
}
