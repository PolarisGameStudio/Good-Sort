using Falcon;

public class CsCheckLevel : CSMessage
{
	public int last_version;

	public int original_version;

	public string app_version;

	public int max_level_of_client;

	public int max_level_get_from_server;

	public CsCheckLevel()
	{
	}

	public CsCheckLevel(int version)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
