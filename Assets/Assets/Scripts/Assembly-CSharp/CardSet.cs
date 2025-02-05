using System;
using System.Collections.Generic;

[Serializable]
public class CardSet
{
	public List<int> cards;

	public int rewardState;

	public CardSet()
	{
	}

	public bool CanClaim()
	{
		return false;
	}

	public CardSet(CardSet cardSet)
	{
	}

	public void Claim()
	{
	}

	public void Update(CardSet cardSet)
	{
	}
}
