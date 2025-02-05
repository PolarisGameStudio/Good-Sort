using System;
using System.Collections.Generic;
using Falcon.FalconAnalytics.Scripts.Enum;
using UnityEngine;

public abstract class MediationBase
{
	public struct AdInfo
	{
		public readonly string AdWhere;

		public readonly int Level;

		public AdInfo(string adWhere, int level)
		{
			AdWhere = null;
			Level = 0;
		}
	}

	protected readonly Dictionary<AdType, AdInfo> AdInfos;

	public abstract void RegisterEvent();

	public abstract void Init(Action callback);

	protected abstract void LoadBanner();

	public abstract void ShowBanner(string where);

	public abstract void HideBanner();

	public abstract bool IsBannerReady();

	public abstract void SetupRectBannerAds(RectTransform rectPanelAds, RectTransform rectButtonRemoveAds);

	protected abstract void LoadInterstitial();

	public abstract bool IsInterstitialReady();

	public abstract void ShowInterstitial(Action onInterstitialClosed = null, string where = "", int level = 0);

	public abstract bool IsRewardedVideoReady();

	public abstract void ShowRewardedVideo(Action<bool> onRewardedComplete, string where = "", int level = 0, bool includePlacement = true);

	public abstract bool IsAppOpenReady();

	public abstract void ShowAppOpen(string where = "", int level = 0, bool includePlacement = true);

	public abstract void LoadAppOpen();
}
