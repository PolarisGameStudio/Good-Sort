using System;
using CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public class PowerupData
{
	public ObscuredInt[] powerups;

	public ObscuredInt[] powerupFrees;

	public void Update(PowerupDataServer powerupData)
	{
	}
}
