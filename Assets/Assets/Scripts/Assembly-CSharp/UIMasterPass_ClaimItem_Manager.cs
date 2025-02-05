using System;
using System.Collections.Generic;
using UnityEngine;

public class UIMasterPass_ClaimItem_Manager : MonoBehaviour
{
	public RectTransform rootItem;

	public RectTransform lockUI;

	public List<UIMasterPass_ClaimItem> items;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void Hide()
	{
	}

	public void SetItem(RectTransform target, List<ResourceValue> rsValue, Action onComplete)
	{
	}
}
