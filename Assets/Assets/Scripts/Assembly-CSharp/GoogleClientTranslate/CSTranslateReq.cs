using Falcon;

namespace GoogleClientTranslate
{
	public class CSTranslateReq : CSMessage
	{
		public string request_uuid;

		public string text;

		public string source_language;

		public string target_language;

		public CSTranslateReq()
		{
		}

		public CSTranslateReq(string text)
		{
		}

		public CSTranslateReq(string text, string sourceLanguage, string targetLanguage)
		{
		}

		private static string GetRemoveRickTextTags(string input)
		{
			return null;
		}

		public override string GetEvent()
		{
			return null;
		}
	}
}
