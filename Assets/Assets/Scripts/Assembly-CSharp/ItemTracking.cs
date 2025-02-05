using System.Collections.Generic;

public class ItemTracking
{
	public int num;

	public ItemType itemType;

	public List<ItemTrackingPos> trackingPoss;

	private int _numItemLayer0;

	private int _layerPriority;

	private int _cellTypePriority;

	public ItemTracking(ItemType itemType, int num, ItemContainer containers, int layer, int index)
	{
	}

	public bool IsContainCellLock()
	{
		return false;
	}

	public int GetNumCell()
	{
		return 0;
	}

	public int GetNumCell(int layer)
	{
		return 0;
	}

	public ItemContainer GetItemContainer(int layer)
	{
		return null;
	}

	public int GetNumItemInLayer_0_OfCellNormal(bool isLevelDrop)
	{
		return 0;
	}

	public int GetLayerPriority()
	{
		return 0;
	}

	public int GetCellTypePriority()
	{
		return 0;
	}

	public int GetDistancePriority()
	{
		return 0;
	}
}
