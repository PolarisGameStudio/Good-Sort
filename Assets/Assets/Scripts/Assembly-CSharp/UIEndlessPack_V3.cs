using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIEndlessPack_V3 : MonoBehaviour
{
	private enum MoveDirection
	{
		None = 0,
		MoveToUp = 1
	}

	private enum Scale
	{
		None = 0,
		Out = 1
	}

	public UITimerCountdownTMP timer;

	public RectTransform rectLock;

	public List<UIEndlessPack_V3_Item> items;

	public TextMeshProUGUI txtWine;

	private List<Vector3> lstAnchorPos;

	private float tweenDurationMove;

	private int c_IndexLastReward;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnClaim(int obj)
	{
	}

	private void UpdateUI_Reward()
	{
	}

	private void Move()
	{
	}
}
