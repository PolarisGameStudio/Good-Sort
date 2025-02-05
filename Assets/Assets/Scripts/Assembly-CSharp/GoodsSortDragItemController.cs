using UnityEngine;

public class GoodsSortDragItemController : Singleton<GoodsSortDragItemController>
{
	private bool _isSelectedCell;

	public GoodSortEditorItem item;

	public bool isDrag;

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

	public GoodSortEditorItem GetGOClicked()
	{
		return null;
	}

	private void Update()
	{
	}

	public void DeleteITem()
	{
	}

	public void BeginDrag(GoodSortEditorItem itemP)
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
