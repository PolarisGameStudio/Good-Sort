using System.Diagnostics;

namespace Falcon
{
	public class LogUtil
	{
		[Conditional("ENABLE_LOG")]
		public static void debug(FMessage message)
		{
		}
	}
}
