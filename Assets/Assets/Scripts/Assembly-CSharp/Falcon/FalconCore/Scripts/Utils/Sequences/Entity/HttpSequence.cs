using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using Falcon.FalconCore.Scripts.Utils.Sequences.Core;
using UnityEngine.Networking;

namespace Falcon.FalconCore.Scripts.Utils.Sequences.Entity
{
	public class HttpSequence : Sequence<string>
	{
		private HttpMethod RequestType { get; }

		private string URL { get; }

		private Dictionary<string, string> Headers { get; }

		private string JsonBody { get; }

		public HttpSequence(HttpMethod requestType, string url, string jsonBody = null, Dictionary<string, string> headers = null)
		{
		}

		protected override IEnumerator<string> EnumeratorT()
		{
			return null;
		}
	}
}
