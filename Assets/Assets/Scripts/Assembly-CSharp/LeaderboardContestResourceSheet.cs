using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class LeaderboardContestResourceSheet
{
	public int id;

	public EncryptedInt[] rewardType;

	public EncryptedInt[] rewardValue;

	public EncryptedInt[] typeIncludeCollection;

	public EncryptedInt[] amountIncludeCollection;

	private static Dictionary<int, LeaderboardContestResourceSheet> dictionary;

	public static LeaderboardContestResourceSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, LeaderboardContestResourceSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, LeaderboardContestResourceSheet> dic)
	{
	}
}
