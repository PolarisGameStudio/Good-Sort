using System.Collections.Generic;
using SuperScrollView;
using UnityEngine;
using UnityEngine.UI;

public class UIClan_NoTeam_Search : MonoBehaviour
{
	public InputField inputFieldName;

	public Button btnRemoveField;

	public Button btnSearch;

	public LoopGridView gridScrollView;

	public RectTransform rectLoading;

	public RectTransform rectEmpty;

	public RectTransform rectSuggest;

	public Button btnOpenSuggest;

	private bool initGridView;

	private List<TeamInfoSimple> c_data;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void UpdateUI()
	{
	}

	private void CheckTimeOut()
	{
	}

	private void StopCheckTimeOut()
	{
	}

	private void OnGetSearchTeamByName(List<TeamInfoSimple> data)
	{
	}

	private LoopGridViewItem InitGridView(LoopGridView view, int itemIndex, int arg3, int arg4)
	{
		return null;
	}
}
