using Falcon;
using Newtonsoft.Json.Linq;

namespace GoogleClientTranslate
{
	public class SCTranslateReq : SCMessage
	{
		public string request_uuid;

		public string text;

		public string target_language;

		public string source_language;

		public override string GetEvent()
		{
			return null;
		}

		public override void OnData()
		{
		}

		public void TranslateText(string sourceText, string targetLanguage, string sourceLanguage)
		{
		}

		
		private static string GetTranslation(JToken translationInfo)
		{
			return null;
		}

		private static string GetDetectedSourceLanguage(JArray item)
		{
			return null;
		}
	}
}
