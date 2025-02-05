using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIShop : MonoBehaviour
{
	[Serializable]
	public class UIPack
	{
		public ItemShopType type;

		public RectTransform rectPack;
	}

	public static Action OnBuyPack;

	public static Action OnCloseUI;

	public ScrollRect rectScrollRecommend;

	public ScrollRect rectScrollAllOffers;

	public UIPack[] packs;

	public Button btnGetMore;

	private List<RectTransform> c_ListClonePackAvaible;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Default()
	{
	}

	public static void CloseUI()
	{
	}

	public static void ConfirmOnBuyPack()
	{
	}
}
