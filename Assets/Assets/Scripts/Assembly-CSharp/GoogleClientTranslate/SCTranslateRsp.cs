using System;
using System.Runtime.CompilerServices;
using Falcon;

namespace GoogleClientTranslate
{
	public class SCTranslateRsp : SCMessage
	{
		public string request_uuid;

		public string text_original;

		public string text_translated;

		public string source_language;

		public string target_language;

		

		public override string GetEvent()
		{
			return null;
		}

		public override void OnData()
		{
		}
	}
}
