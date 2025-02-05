using System;
using System.Collections.Generic;

[Serializable]
public class LunarNewYearDataServer
{
	public int id;

	public int joinEvent;

	public int tutDone;

	public long timeShowPopup;

	public int ltv;

	public int envelope;

	public int totalEnvelope;

	public List<int> rewardsCanClaim;

	public List<SlotDecor> decors;

	public List<int> envelopeBoughts;

	public int buyPack;

	public void Update(LunarNewYearData data)
	{
	}

	public void CheckState()
	{
	}

	public void CSUpdateScore(int score)
	{
	}

	public void GetLeaderboardInfo(int page)
	{
	}

	public void ConfirmEnd()
	{
	}
}
