using Falcon.FalconAnalytics.Scripts.Models.Messages.Interfaces;

namespace Falcon.FalconAnalytics.Scripts.Payloads.Flex
{
	public class TestWrapper : DataWrapper
	{
		public override string URL => null;

		public TestWrapper(string data, long clientSendTime, string @event)
			: base(null, 0L, null)
		{
		}

		public TestWrapper(IDataLog message)
			: base(null, 0L, null)
		{
		}
	}
}
