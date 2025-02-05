public class FalconLevelController : Singleton<FalconLevelController>
{
	private IFalconLevelController iFalconLevel;

	private int resWidth;

	private int resHeight;

	private int screenShotTime;

	public void SetLevelControler(IFalconLevelController falconLevel)
	{
	}

	public void ScreenShot(string levelTxt)
	{
	}
}
