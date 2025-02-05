using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UILeaderboard : MonoBehaviour
{
	public RectTransform rectBlank;

	public UILeaderboard_NavType rectNavType;

	public UILeaderboard_NavType rectNavFriends;

	public Button[] btnTabs;

	public RectTransform[] rectBtnActives;

	public RectTransform[] rectTabs;

	public TextMeshProUGUI txtCountry;

	[Header("Time Contest")]
	public RectTransform rectTimerContest;

	public UITimerCountdownTMP timerContest;

	private int c_index;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OpenTab(int index)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnLocalize()
	{
	}

	private void OnGetContest(bool reset)
	{
	}

	private void UpdateUI_TimerContest(int index)
	{
	}
}
