using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMenuBar : MonoBehaviour
{
	[SerializeField]
	private Button _buttonCell;

	[SerializeField]
	private Button _buttonItem;

	[SerializeField]
	private Button _buttonStatistic;

	[SerializeField]
	private GameObject _panelCell;

	[SerializeField]
	private GameObject _panelItem;

	[SerializeField]
	private GameObject _panelStatistic;

	[SerializeField]
	private GameObject _prefabCellExample;

	[SerializeField]
	private GameObject _prefabItemExample;

	[SerializeField]
	private Button _buttonExport;

	[SerializeField]
	private Button _buttonImport;

	[SerializeField]
	private Button _buttonPlay;

	[SerializeField]
	private Button _buttonReload;

	[SerializeField]
	private TMP_InputField _inputFieldLevel;

	[SerializeField]
	private SOItem _sOItem;

	public List<UIMenuBarItem> uIMenuBarItems;

	private void Awake()
	{
	}

	private void OnReload()
	{
	}

	private void OnChangeItem()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnGetCells(List<GameObject> cells)
	{
	}

	private void OnGetItems(List<GameObject> items)
	{
	}

	private void SetupPrefabUI(List<GameObject> items, GameObject prefabExample)
	{
	}

	private void OnClickButtonCell()
	{
	}

	private void OnClickButtonItem()
	{
	}

	private void OnClickButtonStatistic()
	{
	}

	private void OnClickButtonExport()
	{
	}

	private void OnClickButtonImport()
	{
	}

	private void OnClickButtonPlay()
	{
	}
}
