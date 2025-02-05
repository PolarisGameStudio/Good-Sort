using System;
using System.Collections.Generic;
using DG.Tweening;
using Spine.Unity;
using UnityEngine;

public class HintLevelController : MonoBehaviour
{
	private class DataLayer
	{
		public ItemType itemType;

		public int num;
	}

	[SerializeField]
	private SkeletonAnimation _hand;

	[SerializeField]
	private Transform _handContainer;

	[SerializeField]
	private SpriteRenderer _itemShadow;

	private LevelController _levelController;

	private float _timeWithoutAction;

	private bool _isCallHintMatch3Layer0;

	private List<Tween> _tweensHintMatch3Layer0;

	private List<Coroutine> _coroutineHintMatch3Layer0;

	private bool _isCallHintDragItemToEmptyCell;

	private bool _isCallHintDragItemToAppearMatch3;

	private ItemContainer _currentItemContainerTweenDragItem;

	private int _numItemInLayer0OfCurrentUseItemContainer;

	private bool _isCallHintDragItemFromCellSingleToEmptySlot;

	private int _id;

	private Tween _tween;

	private Action _actionTut;

	private void Start()
	{
	}

	private void OnActivePowerup(PowerupKind kind)
	{
	}

	private void OnDragItem(Item item, Vector2 vector, ItemContainer itemContainerBefore, ItemContainer itemContainerAfter)
	{
	}

	private void OnSelectItem()
	{
	}

	private void ResetDataAndStopHint()
	{
	}

	private void Update()
	{
	}

	public void HintMatch3Layer0()
	{
	}

	private int NumItemInCellLock(List<ItemTrackingPos> trackingPoss, ItemType itemType)
	{
		return 0;
	}

	private bool HasMatch3InLayer0()
	{
		return false;
	}

	public bool HintDragItemToEmptyCell()
	{
		return false;
	}

	private Sprite GetItemSprite(ItemType item)
	{
		return null;
	}

	public bool HintDragItemToAppearMatch3()
	{
		return false;
	}

	private void StartTweenDragItem(ItemContainer itemContainer)
	{
	}

	public bool HintDragItemFromCellSingleToEmptySlot()
	{
		return false;
	}

	private ItemContainer GetItemContainerCanActiveMatch3InLayer1(Dictionary<ItemType, ItemTracking> dataLayer, List<ItemContainer> itemContainers)
	{
		return null;
	}

	public void StartTween(ItemType itemType, Vector2 pos1, Vector2 pos2, int id)
	{
	}

	public void KillAllTween()
	{
	}
}
