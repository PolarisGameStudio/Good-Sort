using System;
using System.Collections.Generic;
using System.Net.Http;
using Falcon.FalconCore.Scripts.Utils.FActions.Base;

namespace Falcon.FalconCore.Scripts.Utils.FActions.Variances.Starts
{
	public class HttpRequest : StartAction, IStartAction<string>, IContinuableAction<string>, IFAction<string>, IFAction, IContinuableAction, IStartAction
	{
		private static readonly HttpClient HttpClient;

		private Exception exception;

		private bool isDone;

		public Dictionary<string, string> Headers { get; set; }

		public string JsonBody { get; set; }

		public HttpMethod RequestType { get; set; }

		public TimeSpan Timeout { get; set; }

		public string URL { get; set; }

		public override Exception Exception => null;

		public override bool Done => false;

		public string Result { get; private set; }

		private static HttpClient GetHttpClient()
		{
			return null;
		}

		public override void Invoke()
		{
		}

		public string InvokeAndGet()
		{
			return null;
		}
	}
}
