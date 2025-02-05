using System;
using TMPro;
using UnityEngine;

public class UIMenuItemDetail : MonoBehaviour
{
	[SerializeField]
	private GameObject _parentContent;

	[SerializeField]
	private GameObject _prefabExample;

	[SerializeField]
	private TextMeshProUGUI _txtTotalItem;

	public static Action onValidateItem;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void ValidateData()
	{
	}

	public void UpdateItems()
	{
	}

	private void AddItems(GameObject item, int num)
	{
	}

	private void ActiveDetail()
	{
	}

	private void DeactiveDetail()
	{
	}

	private void ForceRebuildContent()
	{
	}
}
