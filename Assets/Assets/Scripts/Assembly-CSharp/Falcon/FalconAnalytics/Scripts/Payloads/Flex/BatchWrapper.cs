using System.Collections.Generic;

namespace Falcon.FalconAnalytics.Scripts.Payloads.Flex
{
	public class BatchWrapper : LogWrapper
	{
		public override string URL => null;

		public BatchWrapper(List<DataWrapper> wrappers)
			: base(null)
		{
		}

		protected override void ValidateResponse(string response)
		{
		}

		protected override void TrySend()
		{
		}
	}
}
