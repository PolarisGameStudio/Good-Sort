public class UpdateLevelFromServerController : NMSingleton<UpdateLevelFromServerController>
{
	public string currentLevelData;

	protected override void Init()
	{
	}

	private bool CheckLevel(LevelItem levelItem)
	{
		return false;
	}

	private LevelItem[] Sort(LevelItem[] levels_data)
	{
		return null;
	}

	public void OnGetLevel(int last_version, LevelItem[] levels_data)
	{
	}

	public void OnGetLevelAb(string md5_text_levels, string ab_levels_value, bool delete_all_old_txts, LevelItem[] levels_data)
	{
	}

	private string GetFilePath(int level)
	{
		return null;
	}

	public bool IsContainLevel(int level)
	{
		return false;
	}

	private string GetFilePathAb(int level)
	{
		return null;
	}

	private string GetFilePath(string level)
	{
		return null;
	}

	public bool IsContainLevelAb(int level)
	{
		return false;
	}

	public LevelInfo GetLevelInfo(int level)
	{
		return null;
	}

	public string GetJsonCompress(string level)
	{
		return null;
	}
}
