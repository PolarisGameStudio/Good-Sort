using System;
using Falcon.FalconAnalytics.Scripts.Controllers.Interfaces;

namespace Falcon.FalconAnalytics.Scripts.LogVariance
{
	[Obsolete("DwhLogCache is now fused into DWHLog, there is now no reason to use DwhLogCache anymore.")]
	public static class DwhLogCache
	{
		public static ILog Instance => null;
	}
}
