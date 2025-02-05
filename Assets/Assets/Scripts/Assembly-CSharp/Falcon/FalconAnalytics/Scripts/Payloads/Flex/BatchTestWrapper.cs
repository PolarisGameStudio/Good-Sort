using System;
using System.Collections.Generic;

namespace Falcon.FalconAnalytics.Scripts.Payloads.Flex
{
	[Serializable]
	public class BatchTestWrapper : BatchWrapper
	{
		public override string URL => null;

		public BatchTestWrapper(List<DataWrapper> wrappers)
			: base(null)
		{
		}
	}
}
