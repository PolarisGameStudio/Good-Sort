using UnityEngine;
using UnityEngine.UI;

namespace GoogleClientTranslate
{
	public class TranslateButton : MonoBehaviour
	{
		[SerializeField]
		private Button button;

		[SerializeField]
		private GameObject translateGo;

		[SerializeField]
		private GameObject translatingGo;

		[SerializeField]
		private GameObject revertGo;

		public Button Button => null;

		public void InitStatus(TranslateStatus status)
		{
		}

		public void OnStatusChanged(TranslateStatus oldStatus, TranslateStatus newStatus)
		{
		}

		private void ShowButton(TranslateStatus newStatus)
		{
		}

		private void HideButton(TranslateStatus oldStatus)
		{
		}

		protected virtual void ShowTranslateGo()
		{
		}

		protected virtual void HideTranslateGo()
		{
		}

		protected virtual void ShowTranslatingGo()
		{
		}

		protected virtual void HideTranslatingGo()
		{
		}

		protected virtual void ShowRevertGo()
		{
		}

		protected virtual void HideRevertGo()
		{
		}
	}
}
