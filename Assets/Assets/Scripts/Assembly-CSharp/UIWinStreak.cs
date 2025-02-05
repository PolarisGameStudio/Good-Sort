using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIWinStreak : MonoBehaviour
{
	public bool isTweenLost;

	public TextMeshProUGUI[] txtTimerBonus;

	public Slider progress;

	public SkeletonGraphic[] skeIcons;

	public RectTransform[] targetCurrents;

	public RectTransform rectCurrent;

	public Button btnHelp;

	public UIPopup popupHelp;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}
}
