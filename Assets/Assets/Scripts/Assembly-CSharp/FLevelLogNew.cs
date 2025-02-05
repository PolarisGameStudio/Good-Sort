using System;
using Falcon.FalconAnalytics.Scripts.Enum;
using Falcon.FalconAnalytics.Scripts.Models.Messages.PreDefines;
using UnityEngine.Scripting;

[Serializable]
public class FLevelLogNew : FLevelLog
{
	public string detail;

	[Preserve]
	public FLevelLogNew()
	{
	}

	public FLevelLogNew(int currentLevel, string difficulty, LevelStatus status, TimeSpan duration, int wave, string detail)
	{
	}
}
