public class FrameCollectionController : NMSingleton<FrameCollectionController>
{
	private const string key = "frame_collect";

	private FrameCollection _frame;

	public FrameCollection Frame => null;

	protected override void Init()
	{
	}

	public void SetDataToDefault()
	{
	}

	private void Save()
	{
	}

	public void AddNewFrame(int frame)
	{
	}

	public void UpdateDataFromServer(FrameCollection frames)
	{
	}
}
