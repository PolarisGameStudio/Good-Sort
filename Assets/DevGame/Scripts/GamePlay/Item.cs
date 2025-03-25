using System;
using System.Collections;
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

    public string NameSprHide = "";
    public ItemAsset _itemAsset;

    public bool isNameSpriteAndAspriteShadow()
    {
        return _itemAsset.daIt.sprite == _itemAsset.daIt.spriteHidden;
    }    

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

    public void UpdateItemType(ItemType it)
    {
        _itemType = it;
    }

    public void SetNewItemAsset(ItemAsset item, bool isSetItemType = true)
	{
        _itemAsset = item;
        gameObject.name = item.type.ToString();
        if(isSetItemType)
        {
            _itemType = item.type;
        }
        _sprite.sprite = item.sprite;
        _spriteShadow.sprite = item.spriteHidden;
        NameSprHide = item.spriteHidden.name;
        CheckScale();
    }

    public void CheckScale()
    {
        var scale = LogicGame.Instance.GetScaleItem(ItemType);

        if(scale < 0.1f)
        {
            var sizeItem = _sprite.bounds.size;

            sizeItem.x = sizeItem.x / transform.localScale.x;
            sizeItem.y = sizeItem.y / transform.localScale.x;


            float sizeXMax = 1.1f;
            float sizeYMax = 1.9f;

            float sx = sizeXMax / sizeItem.x;
            float sy = sizeYMax / sizeItem.y;
            scale = Math.Min(sx, sy);
            LogicGame.Instance.AddScale(ItemType, scale);

        }
 
        transform.localScale = Vector3.one * scale;

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
            point = ScStatic.PointItemCell;
        }
        else if (cellType == CellType.CellSingle)
        {
            point = new Vector3(0, 0, 0);
        }
        else
        {
            if (index == 0)
            {
                point = ScStatic.PointItemLeft;
            }

            if (index == 1)
            {
                point = ScStatic.PointItemMid;
            }

            if (index == 2)
            {
                point = ScStatic.PointItemRight;
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
            transform.localPosition = ScStatic.PointItemCell;
        }
        else if (cellType == CellType.CellSingle)
        {
            transform.localPosition = new Vector3(0, 0, 0);
        }
        else
        {
            if (index == 0)
            {
                transform.localPosition = ScStatic.PointItemLeft;
            }

            if (index == 1)
            {
                transform.localPosition = ScStatic.PointItemMid;
            }

            if (index == 2)
            {
                transform.localPosition = ScStatic.PointItemRight;
            }
        }

        PointNomal = transform.localPosition;
        PointShadow = transform.localPosition + new Vector3(0, yAdd, 0);
    }

    private void Awake()
    {
        PointNomal = transform.localPosition;
        PointShadow = transform.localPosition + new Vector3(0, yAdd, 0);
        CurrentScale = transform.localScale;
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
        Audio.Play(ScStatic.SFX_Ingame_PutDownGood);
        OnMoveWhenEndDrag(CurrentPos, false, null);
        if (LogicGame.Instance.IsUseTutorial)
        {
            TutorialGame.instance.OnContinueAnnim();
        }
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


    IEnumerator SetScale()
    {
        transform.localScale = Vector3.one;
        yield return new WaitForEndOfFrame();
        CheckScale();
    }

    public void OnEndMoveSkillSwap(Vector3 vecEnd, Action callback, bool isNomal)
    {
        EndDrag();
        StartCoroutine(SetScale());

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
