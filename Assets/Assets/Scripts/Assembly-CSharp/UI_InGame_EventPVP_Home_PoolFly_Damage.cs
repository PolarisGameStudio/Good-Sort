using System;
using System.Collections.Generic;
using UnityEngine;

public class UI_InGame_EventPVP_Home_PoolFly_Damage : MonoBehaviour
{
	[SerializeField]
	private RectTransform _itemPrefab;

	private Stack<RectTransform> _pools;

	private void Awake()
	{
	}

	private RectTransform GetItem()
	{
		return null;
	}

	public void SpawnItem(Vector2 posSpawn, Vector2 posTarget, Action onDamaged = null)
	{
	}

	private Vector2 GetRandomPositionAround(Vector3 target)
	{
		return default(Vector2);
	}

	private void PlayAnim(UI_InGame_EventPVP_Home_PoorFly_Damage_Item item, string anim, bool isLoop)
	{
	}
}
