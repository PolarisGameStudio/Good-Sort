using Falcon;

public class SCUpdateABLevels : SCMessage
{
	public string md5_text_levels;

	public string ab_levels_value;

	public bool delete_all_old_txts;

	public LevelItem[] levels_data;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
