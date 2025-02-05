using Falcon;

namespace GoogleClientTranslate
{
	public class CSTranslateRsp : CSMessage
	{
		public string request_uuid;

		public string text_original;

		public string text_translated;

		public string source_language;

		public string target_language;

		public CSTranslateRsp()
		{
		}

		public CSTranslateRsp(SCTranslateReq scTranslateReq, string textTranslated, string sourceLanguage)
		{
		}

		public override string GetEvent()
		{
			return null;
		}
	}
}
