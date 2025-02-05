using UnityEngine;
using UnityEngine.UI;

namespace GoogleClientTranslate
{
	public class GoogleClientTranslateSingleForTextLegacy : MonoBehaviour
	{
		[SerializeField]
		private Text translatedText;

		[SerializeField]
		private TranslateButton translateButton;

		private string requestUuid;

		private int fontSize;

		private string translatedTextData;

		private TranslateStatus status;

		public string OriginalTextData { get; private set; }

		public TranslateStatus Status
		{
			get
			{
				return default(TranslateStatus);
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		public void ResetDataCache()
		{
		}

		private void OnTranslateButtonClick()
		{
		}

		public virtual void ResetData()
		{
		}

		public virtual void Refresh()
		{
		}

		protected virtual void OnGetTranslatedDataEvent(SCTranslateRsp sc)
		{
		}

		private void CalcTranslateButtonPosition()
		{
		}

		private void CalcTMPTranslateButtonPosition()
		{
		}

		private void OnStatusChanged(TranslateStatus oldStatus, TranslateStatus newStatus)
		{
		}
	}
}
