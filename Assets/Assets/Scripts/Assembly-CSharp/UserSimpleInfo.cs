using System;

[Serializable]
public class UserSimpleInfo : UserProfile
{
	public int code;

	public int level;

	public int golden;

	public bool IsGoldenFrame()
	{
		return false;
	}
}
