using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class SocialDataController : NMSingleton<SocialDataController>
{
	
	private const string key = "social_data";

	private SocialData _socialData;

	public const string facebookPageID = "408808638980275";

	private Coroutine coroutineCheckOpenFacebook;

	public SocialData SocialData => null;

	protected override void Init()
	{
	}

	private void OnApplicationPause(bool obj)
	{
	}

	public void SetDataToDefault()
	{
	}

	private void Save()
	{
	}

	public ObscuredInt GetGoldLikeFanpage()
	{
		return default(ObscuredInt);
	}

	public ResourceValue GetResourceWhenLikeFanpage()
	{
		return null;
	}

	public bool CanLikeFanpage()
	{
		return false;
	}

	public void OpenFacebookPage()
	{
	}

	private IEnumerator CoroutineDelayOpenFacebook()
	{
		return null;
	}

	public void LikeFanpage()
	{
	}

	public void UpdateDataFromServer(SocialData socialData)
	{
	}
}
