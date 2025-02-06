using System;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

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

	private List<KillTween> _tweens;

	private bool _isDeSpawn;

	private GameObject _fxGoldenGift;

	private const float colorShadow = 0.313f;

	public static Dictionary<ItemType, float> dicItemHeight;


	public ItemType ItemType => _itemType;

	public bool IsDeSpawn => false;

	public Vector3 CurrentPos = Vector3.zero;

	public float HalfHeight => 0f;

	private void Awake()
	{
	}

	public void CompleteTween()
	{
	}

	private void OnEnable()
	{
	}

	public void AddTween(Tween tween, bool completeWhenKill)
	{
	}

	public void ActiveVisual(bool active)
	{
	}

	public bool IsGoldenGift()
	{
		return false;
	}

	public void SetupVisual(ItemContainer itemContainer, ItemAsset item, bool active, int index)
	{
	}

	private void SetSortingOrder(SpriteRenderer sp, int order)
	{
        sp.sortingOrder = order;
    }

	public void Setup(ItemContainer itemContainer, ItemAsset item, bool active, int index, int indexContanier)
	{
		this.itemContainer = itemContainer;

        gameObject.name = item.type.ToString();
		_itemType = item.type;
		_sprite.sprite = item.sprite;
		_spriteShadow.sprite = item.spriteHidden;

        var sizeItem = _sprite.bounds.size;

        float sx = 0.95f / sizeItem.x;

        if (sx < 0.95f)
		{
            transform.localScale = Vector3.one * sx;
        }

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

		if(indexContanier == 0)
		{
			EnableItemNormal();
        }
		else
		{
			EnableItemShadow();
        }

        if (!active && indexContanier != 1)
		{
            gameObject.SetActive(false);
        }

        if (indexContanier == 1)
        {
            gameObject.SetActive(true);
        }
    }

	public void EnableItemNormal()
	{
        gameObject.SetActive(true);
        SetSortingOrder(_sprite, layer);
        SetSortingOrder(_spriteShadow, layerBehind);
        Color color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        _sprite.color = color;
        _collider.enabled = true;
    }

    public void EnableItemShadow()
	{
        gameObject.SetActive(true);
        SetSortingOrder(_sprite, layer - 1);
        SetSortingOrder(_spriteShadow, layerBehind - 1);
        _collider.enabled = false;
        _spriteShadow.gameObject.SetActive(false);
        Color color = new Color(colorShadow, colorShadow, colorShadow, 1.0f);
        _sprite.color = color;
    }


	public void BeginDrag()
	{
		CurrentPos = transform.position;
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
		transform.position = CurrentPos;
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

	public void OnNextLayerItemCurrentContainer()
	{
		if(!itemContainer.Equals(itemContainerNew))
		{
			itemContainer.OnNextItemWhenMove();

        }
	}
}
