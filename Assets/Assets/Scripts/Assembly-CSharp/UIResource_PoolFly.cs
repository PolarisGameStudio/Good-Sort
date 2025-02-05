using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIResource_PoolFly : MonoBehaviour
{
	public static Action<ResourceType, int> onFlyItemToTargetComplete;

	public AnimationCurve curve;

	[SerializeField]
	private Image _itemPrefab;

	[SerializeField]
	private Image _itemPrefab_Gold;

	[SerializeField]
	private Image _itemPrefab_Hearth;

	private Stack<Image> _pools;

	private Stack<Image> _pool_Golds;

	private Stack<Image> _pool_Hearths;

	private int num_pre_spawn;

	private WaitForSeconds waitSpawnGold;

	private WaitForSeconds waitSpawn;

	private Vector3[] paths;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private Image GetItem(ResourceType kind)
	{
		return null;
	}

	public void Spawn(ResourceType kindFly, Vector2 position, Vector3 target, int number, int totalResources = 0)
	{
	}

	private void SpawnItem(Vector3 postion, Vector3 target, ResourceType kindFly, int number, List<int> valueItems)
	{
	}

	private List<int> CreateListWithTotal(int total, int n)
	{
		return null;
	}
}
