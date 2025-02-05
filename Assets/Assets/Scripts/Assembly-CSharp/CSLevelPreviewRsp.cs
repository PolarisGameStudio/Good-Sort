using Falcon;

public class CSLevelPreviewRsp : CSMessage
{
	public string level_data;

	public byte[] image;

	public CSLevelPreviewRsp(string level_data, byte[] image)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
