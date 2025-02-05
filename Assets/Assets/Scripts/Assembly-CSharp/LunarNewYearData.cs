using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

public class LunarNewYearData
{
	public int id;

	public int joinEvent;

	public int tutDone;

	public long timeShowPopup;

	public int ltv;

	public ObscuredInt envelope;

	public ObscuredInt totalEnvelope;

	public List<int> rewardsCanClaim;

	public List<SlotDecor> decors;

	public List<int> envelopeBoughts;

	public int buyPack;

	public void Update(LunarNewYearDataServer data)
	{
	}
}
