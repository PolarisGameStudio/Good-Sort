using Coffee.UIExtensions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_HiddenTreasure_FindPlayer : MonoBehaviour
{
	public Image BG;

	public TextMeshProUGUI txtMax;

	public TextMeshProUGUI txtCount;

	public UIParticle fxComplete;

	public UIHiddenTreasure_Target target;

	public RectTransform rectHideUI;

	private void OnEnable()
	{
	}
}
