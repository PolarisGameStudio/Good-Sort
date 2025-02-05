using UnityEngine;

public class GoodSortEditorItem : MonoBehaviour
{
	public GoodSortEditorCell LastCellContain;

	[SerializeField]
	private ItemType _type;

	[SerializeField]
	private SpriteRenderer _spriteRenderer;

	public ItemType Type
	{
		get
		{
			return default(ItemType);
		}
		set
		{
		}
	}

	public void ActiveItem(bool enabled)
	{
	}
}
