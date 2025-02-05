using System;

[Serializable]
public class HidenTreasure
{
	public int showTut;

	public int state;

	public long timeStart;

	public int level;

	public int playerRemain;

	public int prePlayer;

	public int avatar;

	public int dropType;

	public int numPlay;

	public HidenTreasureState GetHideTreasureState()
	{
		return default(HidenTreasureState);
	}

	public void Update(HidenTreasure hidenTreasure)
	{
	}
}
