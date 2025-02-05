using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace GoogleClientTranslate
{
	public class GoogleClientTranslateGroup : MonoBehaviour
	{
		[SerializeField]
		private TranslateButton translateButton;

		[SerializeField]
		private List<TextMeshProUGUI> needTranslateList;

		private List<TranslateUnit> translateUnitList;

		private List<string> requestingUuidList;

		private TranslateStatus status;

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

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void InitTranslateUnitList()
		{
		}

		private void OnGetTranslatedData(SCTranslateRsp rsp)
		{
		}

		private void OnClickTranslateButton()
		{
		}

		private void Translate()
		{
		}

		private void TranslatePieceByPiece()
		{
		}

		private void Revert()
		{
		}

		private void StopTranslate()
		{
		}

		private void OnTextChangedCallback()
		{
		}

		private void RefreshStatus()
		{
		}

		private void ResetData()
		{
		}

		public void PublicRefresh()
		{
		}

		public void AddNewTMP(TextMeshProUGUI newTmp)
		{
		}
	}
}
