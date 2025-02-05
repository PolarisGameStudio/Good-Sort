using System;

public class ShowAdsBannerInGameController : Singleton<ShowAdsBannerInGameController>
{
	public Action onHideBanner;

	public Action onShowBanner;

	protected override void Awake()
	{
	}

	private void OnDisable()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void ShowBanner()
	{
	}

	public void HideBanner()
	{
	}

	public void CheckShowBanner()
	{
	}

	public bool CanShowBanner()
	{
		return false;
	}
}
