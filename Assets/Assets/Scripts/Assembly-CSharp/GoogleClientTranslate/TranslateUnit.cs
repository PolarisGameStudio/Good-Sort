using System;
using TMPro;
using UnityEngine.UI;

namespace GoogleClientTranslate
{
	[Serializable]
	public class TranslateUnit
	{
		public TextMeshProUGUI originalTextTmp;

		public Text translatedText;

		public TranslateStatus status;

		public TranslateData translateData;

		private bool textAvailable;

		private float defaultTmpAlpha;

		public TranslateUnit(TextMeshProUGUI originalTextTmp)
		{
		}

		public bool HasChanged()
		{
			return false;
		}

		public void ResetData()
		{
		}

		public void SpawnText(string translateTextData)
		{
		}

		public void Revert()
		{
		}

		public void StopTranslate()
		{
		}

		public CSTranslateReq PrepareMessage()
		{
			return null;
		}

		public bool NeedTranslate()
		{
			return false;
		}

		public void TranslateDependOnData()
		{
		}
	}
}
