using System;
using CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public class UserResource
{
	public ObscuredInt heart;

	public ObscuredInt gold;

	public ObscuredInt star;

	public long lastUpdateHeart;

	public long timeInfiHeart;

	public long timeX2Reward;

	public long timeQuit;

	public void Update(UserResourceServer userResource)
	{
	}
}
