using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GoogleClientTranslate
{
	public class GoogleClientTranslateSingle : MonoBehaviour
	{
		[SerializeField]
		protected TextMeshProUGUI originalTextTmp;

		[SerializeField]
		private TranslateButton translateButton;

		private Text translatedText;

		private string requestUuid;

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

		private void CalcTextTranslateButtonPosition()
		{
		}

		private void OnStatusChanged(TranslateStatus oldStatus, TranslateStatus newStatus)
		{
		}
	}
}
