using UnityEngine;

public class HalloweenLevelContainer : PersistentSingleton<HalloweenLevelContainer>
{
	[SerializeField]
	private Board[] _levels;

	public Board GetBoard(int level)
	{
		return null;
	}
}
