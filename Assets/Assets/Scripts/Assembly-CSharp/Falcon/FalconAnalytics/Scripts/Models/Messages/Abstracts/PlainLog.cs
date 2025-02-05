using System;
using System.Collections.Generic;
using Falcon.FalconAnalytics.Scripts.Models.Attributes;
using Falcon.FalconAnalytics.Scripts.Models.Messages.Interfaces;
using Falcon.FalconAnalytics.Scripts.Payloads.Flex;
using Newtonsoft.Json;

namespace Falcon.FalconAnalytics.Scripts.Models.Messages.Abstracts
{
	[Serializable]
	public abstract class PlainLog : IDataLog
	{
		[FKey(Ignore = true)]
		public long clientCreateDate;

		[JsonIgnore]
		public long CreatedTime => 0L;

		public virtual string Event => null;

		public DataWrapper Wrap()
		{
			return null;
		}

		public virtual Dictionary<string, object> ToDictionary()
		{
			return null;
		}

		public virtual void Send()
		{
		}
	}
}
