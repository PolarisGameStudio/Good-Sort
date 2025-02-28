using System;
using System.Collections.Generic;
using DG.Tweening;

using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Item : MonoBehaviour
{
	public class KillTween
	{
		public Tween tween;

		public bool complete;

		public KillTween(Tween tween, bool complete)
		{
		}
	}

	private static Vector3 pos_shadow_deselect;

	private static Vector3 pos_shadow_selecting;

	private const int layer = 1000;

	private const int layerBehind = 999;

	private const int layerWhenSelecting = 2000;

	[SerializeField]
	private ItemType _itemType;

	[SerializeField]
	private SpriteRenderer _sprite;

	[SerializeField]
	private SpriteRenderer _spriteShadow;

	[SerializeField]
	private BoxCollider2D _collider;

	public ItemContainer itemContainer;

	public ItemContainer itemContainerNew;

	private const float colorShadow = 0.313f;

	public ItemType ItemType => _itemType;

	public Vector3 CurrentPos = Vector3.zero;

	private Vector3 PointNomal = Vector3.zero;
    private Vector3 PointShadow = Vector3.zero;
    private Vector3 CurrentScale = Vector3.zero;


	private void SetSortingOrder(SpriteRenderer sp, int order)
	{
        if(this == null || sp == null)
        {
            int kk = 0;
        }    
        sp.sortingOrder = order;
    }

    float yScale = 0.025f;
	float yAdd = 0.1f;

	public void SetNewItemAsset(ItemAsset item)
	{
        gameObject.name = item.type.ToString();
        _itemType = item.type;
        _sprite.sprite = item.sprite;
        _spriteShadow.sprite = item.spriteHidden;
        CheckScale();
    }

    public void CheckScale()
    {
        transform.localScale = Vector3.one;
        var sizeItem = _sprite.bounds.size;

        float sx = 1.0f / sizeItem.x;

        if (sx < 1.0f)
        {
            transform.localScale = Vector3.one * sx;
        }

        UpdateScaleCurrent(transform.localScale);
    }    

    public void SetItemContainer(ItemContainer itemContaine)
    {
        this.itemContainer = itemContaine;
    }

    public void Setup(ItemContainer itemContainer, ItemAsset item, bool active, int index, int indexContanier, CellType cellType)
	{
		this.itemContainer = itemContainer;

		SetNewItemAsset(item);

        SetPointForItem(index, cellType);


        if (indexContanier == 0)
		{
			EnableItemNormal(false);
        }
		else
		{
			EnableItemShadow(false);
        }

        if (!active && indexContanier != 1)
		{
            gameObject.SetActive(false);
        }

        if (indexContanier == 1 && itemContainer.CellType != CellType.CellLayerCount)
        {
            gameObject.SetActive(true);
        }
    }

    public Vector3 GetPoinItem(int index, CellType cellType)
    {
        var point = Vector3.zero;
        if (cellType == CellType.CellLayerCount)
        {
            point = new Vector3(0, 0.155f, 0);
        }
        else if (cellType == CellType.CellSingle)
        {
            point = new Vector3(0, 0, 0);
        }
        else
        {
            if (index == 0)
            {
                point = new Vector3(-1, 0, 0);
            }

            if (index == 1)
            {
                point = new Vector3(0, 0, 0);
            }

            if (index == 2)
            {
                point = new Vector3(1, 0, 0);
            }
        }

        PointNomal = point;
        PointShadow = point + new Vector3(0, yAdd, 0);
        return point;
    }    

	public void SetPointForItem(int index, CellType cellType)
	{
        if (cellType == CellType.CellLayerCount)
        {
            transform.localPosition = new Vector3(0, 0.155f, 0);
        }
        else if (cellType == CellType.CellSingle)
        {
            transform.localPosition = new Vector3(0, 0, 0);
        }
        else
        {
            if (index == 0)
            {
                transform.localPosition = new Vector3(-1, 0, 0);
            }

            if (index == 1)
            {
                transform.localPosition = new Vector3(0, 0, 0);
            }

            if (index == 2)
            {
                transform.localPosition = new Vector3(1, 0, 0);
            }
        }

        PointNomal = transform.localPosition;
        PointShadow = transform.localPosition + new Vector3(0, yAdd, 0);
    }

	public void UpdateScaleCurrent(Vector3 scale)
	{
		CurrentScale = scale;
		transform.localScale = scale;
    }

	public void EnableItemNormal(bool isSet)
	{
        gameObject.SetActive(true);
        SetSortingOrder(_sprite, layer);
        SetSortingOrder(_spriteShadow, layerBehind);
        Color color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        _sprite.color = color;
        _collider.enabled = true;
		if(isSet)
		{
			OnMoveWhenEndDrag(PointNomal, false, null, 0.05f);
            transform.localScale = CurrentScale - Vector3.one* yScale;
        }
    }

    public void EnableItemShadow(bool isSet)
	{
		if(itemContainer.CellType == CellType.CellLayerCount)
		{
            gameObject.SetActive(false);
        }else
		{
            gameObject.SetActive(true);
        }
        SetSortingOrder(_sprite, layer - 1);
        SetSortingOrder(_spriteShadow, layerBehind - 1);
        _collider.enabled = false;
        _spriteShadow.gameObject.SetActive(false);
        Color color = new Color(colorShadow, colorShadow, colorShadow, 1.0f);
        _sprite.color = color;
		transform.localPosition = PointShadow + new Vector3(0, yAdd, 0);
        transform.localScale = CurrentScale + Vector3.one * yScale;
    }

    public void OnMoveWhenEndDrag(Vector2 pointMove, bool isRunAnimScale, Action callback, float delayTime = 0.0f, float timeMove = 0.0f)
    {
		var currentPos = transform.localPosition;
		var dis = Vector2.Distance(currentPos, pointMove);
		var time = timeMove < 0.001f ? dis / 400 : timeMove;

        _collider.enabled = false;

        transform.DOLocalMove(pointMove, time).OnComplete(() =>
		{
			//transform.localPosition = pointMove;
			if(isRunAnimScale)
			{
				RunAnimScale(callback);
			}
			else
			{
                _collider.enabled = true;
                callback?.Invoke();
            }

        }).SetEase(Ease.OutBack).SetDelay(delayTime);
    }
	
	public void RunAnimScale(Action callback)
	{
        var ScaleAdd = new Vector3(0.2f, -0.15f);
        transform.DOScale(CurrentScale + ScaleAdd, 0.1f).OnComplete(() =>
        {
            transform.DOScale(transform.localScale - ScaleAdd, 0.1f).OnComplete(() =>
            {
                callback?.Invoke();
                _collider.enabled = true;
            });
        });
    }	

	public void SetMaxOrderLayerForSprite()
	{
        SetSortingOrder(_sprite, layerWhenSelecting);
    }

    public void ResetMaxOrderLayerForSprite()
	{
        SetSortingOrder(_sprite, layer);
    }

    public void BeginDrag()
	{
		CurrentPos = transform.localPosition;
		SetSortingOrder(_sprite, layerWhenSelecting);
        SetSortingOrder(_spriteShadow, layerWhenSelecting - 1);
    }

    public void EndDrag()
	{
        SetSortingOrder(_sprite, layer);
        SetSortingOrder(_spriteShadow, layer - 1);
    }

	public void OnMoveFailed()
	{
		///
		OnMoveWhenEndDrag(CurrentPos, false, null);
	}

	public void CheckEndItem(Cell celNew)
	{
        itemContainerNew = celNew.ItemContainer;
        celNew.CheckEndItem(this);
    }

	public void OnUpdateItemContainer()
	{
		itemContainer = itemContainerNew;
	}

	public bool IsEquasItemContainer()
	{
		if(itemContainerNew == null)
		{
			return false;
		}

		return itemContainer.Equals(itemContainerNew);
	}

	public void OnNextLayerItemCurrentContainer()
	{
		if(!itemContainer.Equals(itemContainerNew))
		{
			itemContainer.OnNextItemWhenMove();
        }
	}

	public void OnRemoveDotCellTypeOneSlot()
	{
        if (!itemContainer.Equals(itemContainerNew))
		{
            itemContainer.RemoveDotTypeCellOneSlot();
        }
    }

	public void OnLockItem()
	{
		_collider.enabled = false;
	}

	public void OnUnlockItem()
	{
        _collider.enabled = true;
    }

    public void OnStartMoveSkillSwap(Vector3 pointMove, Action callback, float timeMove = 0.25f)
    {
        SetSortingOrder(_sprite, layerWhenSelecting);
        SetSortingOrder(_spriteShadow, layerWhenSelecting - 1);
        Vector3 vecCurrent = transform.position;
        float x = 0.0f, y = 0.0f, add = 1.5f;
        if(vecCurrent.x < pointMove.x)
        {
            x =- UnityEngine.Random.Range(0.0f, 1.0f) * add;
        }

        if (vecCurrent.x >= pointMove.x)
        {
            x = UnityEngine.Random.Range(0.0f, 1.0f) * add;
        }

        if (vecCurrent.y < pointMove.y)
        {
            y = -UnityEngine.Random.Range(0.0f, 1.0f) * add;
        }

        if (vecCurrent.y >= pointMove.y)
        {
            y = UnityEngine.Random.Range(0.0f, 1.0f) * add;
        }
        Vector3 pMoveAdd = new Vector3(x, y, 0);

        transform.DOMove(transform.position + pMoveAdd, 0.1f).OnComplete(() => {

            transform.DOMove(pointMove, timeMove).SetEase(Ease.InOutQuad).OnComplete(() =>
            {
                callback?.Invoke();
            });

        }).SetEase(Ease.InOutBack).SetDelay(UnityEngine.Random.Range(0.0f, 1.0f) * 0.25f);

    }

    public void OnEndMoveSkillSwap(Vector3 vecEnd, Action callback, bool isNomal)
    {
        EndDrag();
        CheckScale();

        if (isNomal)
        {
            EnableItemNormal(false);
        }
        else
        {
            if (itemContainer.Cell.CellType != CellType.CellLayerCount)
            {
                EnableItemShadow(false);
            }
        }
        transform.DOLocalMove(vecEnd, 0.25f).OnComplete(() =>
        {
            callback?.Invoke();
        }).SetEase(Ease.InOutBack);
    }    
}
