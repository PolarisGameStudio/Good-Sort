using System.Collections.Generic;
using UnityEngine;

public class UIEndlessPack : MonoBehaviour
{
	private enum MoveDirection
	{
		None = 0,
		MoveToLeft = 1,
		MoveToRight = 2,
		MoveToUp = 3
	}

	private enum Scale
	{
		None = 0,
		Out = 1
	}

	public UITimerCountdownTMP timer;

	public List<UIEndlessPack_Item> items;

	public RectTransform rectLock;

	private List<Vector3> lstAnchorPos;

	private float tweenDurationMove;

	private int c_IndexLastReward;

	private int c_IndexComingSoon;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnClaim(int indexClaim)
	{
	}

	private void UpdateUI_Reward()
	{
	}

	private void Move()
	{
	}
}
