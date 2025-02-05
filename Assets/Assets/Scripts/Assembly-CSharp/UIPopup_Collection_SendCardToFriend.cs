using System.Collections.Generic;
using SuperScrollView;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Collection_SendCardToFriend : MonoBehaviour
{
	public InputField inputFieldName;

	public Button btnRemoveField;

	public Button btnSearch;

	public LoopGridView gridScrollView;

	public UIPanel_TimeOutLoading rectLoading;

	public RectTransform rectEmpty;

	private bool initGridView;

	private List<UserSimpleInfoWithTeam> c_data;

	private int c_SetCard;

	private int c_IndexCard;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnSendCardToFriend()
	{
	}

	private void OnGetFriends(List<UserSimpleInfoWithTeam> data)
	{
	}

	private LoopGridViewItem InitGridView(LoopGridView view, int itemIndex, int arg3, int arg4)
	{
		return null;
	}

	public void UpdateUI(int setCard, int indexCard)
	{
	}
}
