using System;
using System.Collections.Generic;
using UnityEngine;

public class GoodSortEditorEvents
{
	private static GoodSortEditorEvents _instance;

	public Action<List<GameObject>> OnGetCells;

	public Action<List<GameObject>> OnGetItems;

	public Action<GameObject> OnSpawn;

	public Action<GoodSortEditorBoard> OnSetupBoard;

	public Action<GoodSortEditorItem> OnUpdateBoard;

	public Action<int> OnChangeTime;

	public Action<int> OnChangeItemHiden;

	public Action<int> OnChangeLock;

	public Action<float> OnChangeWidthView;

	public Action<float> OnChangeWidthAvailable;

	public Action OnBoardClickNextLayer;

	public Action OnBoardClickPreviousLayer;

	public Action<int> OnBoardChangeLayer;

	public Action OnSelectItemDetail;

	public Action OnSelectCellDetail;

	public Action<GameObject, int> OnAddItemSelected;

	public Action OnChangeItem;

	public Action OnUpdateUIItem;

	public Action<string> OnExport;

	public Action<string> OnImport;

	public Action<string> OnPlay;

	public Action OnImportDone;

	public static GoodSortEditorEvents Instance => null;
}
