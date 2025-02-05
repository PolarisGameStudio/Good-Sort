using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;

public class PowerupSwap : MonoBehaviour, IBooster
{
	private class LayerData
	{
		public Dictionary<ItemType, int> dicItem;

		public int numMatch3InCell;

		public int numMatch2InCell;

		public int numEmptySlot;

		public int numCell;

		public List<ItemContainer> itemContainers;

		public void AddItem(ItemType itemType, int num = 1)
		{
		}

		public void RemoveItem(ItemType itemType, int num)
		{
		}
	}


	[SerializeField]
	private SkeletonAnimation _anim;

	[SerializeField]
	private Transform _fx;

	[SerializeField]
	private ParticleSystem _fxBurt;

	private const int max_pos_y_in_level_drop = 15;

	public void Active(LevelController levelController)
	{
	}

	private IEnumerator CoroutineActive(LevelController levelController)
	{
		return null;
	}
}
