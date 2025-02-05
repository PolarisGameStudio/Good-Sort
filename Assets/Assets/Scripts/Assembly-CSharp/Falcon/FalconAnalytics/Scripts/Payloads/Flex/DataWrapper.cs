using System;
using Falcon.FalconAnalytics.Scripts.Models.Messages.Interfaces;
using Newtonsoft.Json;
using UnityEngine.Scripting;

namespace Falcon.FalconAnalytics.Scripts.Payloads.Flex
{
	[Serializable]
	public class DataWrapper : LogWrapper
	{
		public long clientSendTime;

		public string @event;

		public string packageName;

		public string platform;

		public override string URL => null;

		[Preserve]
		[JsonConstructor]
		public DataWrapper(string data, long clientSendTime, string @event)
			: base(null)
		{
		}

		[Preserve]
		public DataWrapper(IDataLog message)
			: base(null)
		{
		}

		private DataWrapper(IDataLog message, string @event)
			: base(null)
		{
		}

		protected override void ValidateResponse(string response)
		{
		}
	}
}
