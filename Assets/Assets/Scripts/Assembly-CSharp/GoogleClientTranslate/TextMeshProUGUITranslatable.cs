using TMPro;
using UnityEngine;

namespace GoogleClientTranslate
{
	[RequireComponent(typeof(GoogleClientTranslateSingle))]
	public class TextMeshProUGUITranslatable : TextMeshProUGUI
	{
		[SerializeField]
		private GoogleClientTranslateSingle translateBase;

		public override string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
