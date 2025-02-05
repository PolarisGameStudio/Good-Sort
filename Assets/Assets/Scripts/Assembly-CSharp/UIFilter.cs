using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFilter : MonoBehaviour
{
	public Toggle togglePrefab;

	public Transform filterItemBase;

	public Transform filterKindContainer;

	public Transform filterColorContainer;

	public Button buttonOnOff;

	public GameObject container;

	public SOItemBase sOItemBase;

	public List<Toggle> togglesItemBase;

	public List<Toggle> togglesKind;

	public List<Toggle> togglesColor;

	public static List<string> itemBase;

	public static List<ItemKind> itemKindsFilter;

	public static List<ItemColor> itemColorFilter;

	public static List<ItemType> itemTypeFilterByItembase;

	public static Action onUpdateData;

	public List<ItemType> GetItemsFilterByItemBase()
	{
		return null;
	}

	private void Awake()
	{
	}

	public void UpdataData(bool p)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
