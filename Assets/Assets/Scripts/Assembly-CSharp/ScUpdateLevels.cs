using Falcon;

public class ScUpdateLevels : SCMessage
{
	public int last_version;

	public LevelItem[] levels_data;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
