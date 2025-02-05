using Falcon;

public class CsLogin : CSMessage
{
	public int code;

	public string token;

	public string device_id;

	public int sequence;

	public int app_version_int;

	public string platform;

	public string fbId;

	public string googleId;

	public string appleId;

	public CsLogin(int code, string token, string device_id, int sequence, int appVersion, string platform)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
