using System.Collections.Generic;
using Falcon;

public class CSUpdateLevelEventPVP : CSMessage
{
	public int damageToOpponent;

	public List<string> steps;

	public CSUpdateLevelEventPVP(int damageToOpponent, List<string> steps)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
