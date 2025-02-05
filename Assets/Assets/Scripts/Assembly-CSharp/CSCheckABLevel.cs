using Falcon;

public class CSCheckABLevel : CSMessage
{
	public string md5_text_levels;

	public string ab_levels_value;

	public string app_version;

	public CSCheckABLevel(string md5_text_levels, string ab_levels_value)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
