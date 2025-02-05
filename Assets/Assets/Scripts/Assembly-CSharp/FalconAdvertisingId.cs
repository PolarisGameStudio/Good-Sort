using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Falcon.FalconCore.Scripts.Controllers.Interfaces;

public class FalconAdvertisingId : IFInit
{

	private const string FALCON_ADVERTISING_ID = "falcon_analytics_advertising_id";

	public static string falconAdvertisingId;

	public IEnumerator Init()
	{
		return null;
	}
}
