using System.Collections.Generic;
using SuperScrollView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Resource_FreeLives : MonoBehaviour
{
	public TextMeshProUGUI txtTotal;

	public LoopGridView gridScrollView;

	public RectTransform rectLoading;

	[Header("Empty")]
	public RectTransform rectEmpty;

	public Button btnRequestEmpty;

	public UIPopup popupRequestJoinTeam;

	private bool initGridView;

	private List<FreeLiveRowData> c_data;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnReceiveFreeLive()
	{
	}

	private void UpdateUI_Scroll()
	{
	}

	private void UpdateTotalLives()
	{
	}

	private void OnGetFreeLive()
	{
	}

	private LoopGridViewItem InitGridView(LoopGridView view, int itemIndex, int arg3, int arg4)
	{
		return null;
	}
}
