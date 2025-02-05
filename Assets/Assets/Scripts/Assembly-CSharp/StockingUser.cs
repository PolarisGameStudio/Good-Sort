using System;

[Serializable]
public class StockingUser : UserProfile
{
	public int point;

	public int prePoint;

	public bool yourSelf;

	public bool golden;

	public int rank;

	public StockingUser()
	{
	}

	public StockingUser(StockingUser user)
	{
	}
}
