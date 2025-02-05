using UnityEngine;

public class GoodSortEditorLevelConverter : Singleton<GoodSortEditorLevelConverter>
{

	[SerializeField]
	private SOAllLevel _sOAllLevel;

	private GoodSortEditorBoard _board;

	private int _time;

	private int _itemHiden;

	private int _lock;

	public int Time
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int ItemHiden
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Lock
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void OnSetupBoard(GoodSortEditorBoard board)
	{
	}

	public void ExportInSOLevel(int index)
	{
	}

	public void ExportInSOLevel(SOLevel sOLevel)
	{
	}

	public void ExportInSOLevelByName(string name)
	{
	}

	private void OnExport(string levelText)
	{
	}

	private void OnPlay(string levelText)
	{
	}

	private void OnImport(string levelText)
	{
	}

	private void OnChangeTime(int time)
	{
	}

	private void OnChangeItemHiden(int obj)
	{
	}

	private void OnChangeLock(int lockValue)
	{
	}

	private string GetLevelInfo()
	{
		return null;
	}

	private string GetLevelInfo(LevelInfoEditorExtend levelInfo)
	{
		return null;
	}

	public LevelInfoEditorExtend GetLevelInfo1()
	{
		return null;
	}
}
