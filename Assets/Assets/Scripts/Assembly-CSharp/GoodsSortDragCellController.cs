using System;
using UnityEngine;

public class GoodsSortDragCellController : Singleton<GoodsSortDragCellController>
{
	private bool _isSelectedCell;

	public GoodSortEditorCell cell;

	public Action<GoodSortEditorCell> onSelectCell;

	public Action<GoodSortEditorCell> onInstantiateCell;

	private Vector3 posClickDown;

	private Vector3 startPos;

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void OnSelectCell()
	{
	}

	private void OnSelectItem()
	{
	}

	public static bool IsPointerOverUIObject()
	{
		return false;
	}

	public Vector3 GetMousePosition()
	{
		return default(Vector3);
	}

	public GoodSortEditorCell GetGOClicked()
	{
		return null;
	}

	private void Update()
	{
	}

	public void DeleteCell()
	{
	}

	public void BeginDrag(GoodSortEditorCell cellP)
	{
	}

	public void BeginDrag()
	{
	}

	public void Drag()
	{
	}

	public void EndDrag()
	{
	}
}
