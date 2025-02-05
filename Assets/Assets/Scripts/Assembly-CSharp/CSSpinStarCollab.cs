using Falcon;

public class CSSpinStarCollab : CSMessage
{
	public int index;

	public int milk;

	public int score;

	public int milkToPartner;

	public CSSpinStarCollab(int index, int milk, int score, int milkToPartner)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
