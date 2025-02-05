using System;
using System.Collections.Generic;
using UnityEngine;

public class UI_InGame_Home_PoolFly_StarCombo : MonoBehaviour
{
	[SerializeField]
	private RectTransform _itemPrefab;

	private Stack<RectTransform> _pools;

	public Action<int> onStarDone;

	private void Awake()
	{
	}

	private RectTransform GetItem()
	{
		return null;
	}

	public void SpawnItem(Vector2 postion, Vector3 target, int numberStarCanReceive)
	{
	}

	private List<int> CreateListWithTotal(int total, int n)
	{
		return null;
	}
}
