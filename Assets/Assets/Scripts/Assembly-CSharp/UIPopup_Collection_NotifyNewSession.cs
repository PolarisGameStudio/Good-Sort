using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Collection_NotifyNewSession : MonoBehaviour
{
	public static int s_IndexBadgeEndSession;

	public SkeletonGraphic skeBanner;

	public UITimerCountdownTMP timer;

	public TextMeshProUGUI txtDescription;

	public Button btnExit;

	public Button btnPlay;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}
}
