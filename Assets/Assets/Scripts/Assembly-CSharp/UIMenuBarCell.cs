using UnityEngine;

public class UIMenuBarCell : MonoBehaviour
{
	[SerializeField]
	private RectTransform _previewParent;

	[SerializeField]
	private GameObject _prefabPreviewImage;

	private GameObject _prefab;

	private GoodSortEditorCell _cell;

	private SpriteRenderer[] _spritesToPreview;

	private float _pixel;

	private Vector3 _defaultScaleParentPreview;

	private void Awake()
	{
	}

	private void SetupEventTrigger()
	{
	}

	public void SetupPreview(GameObject item)
	{
	}

	private void OnBeginDrag()
	{
	}

	private void OnDrag()
	{
	}

	private void OnEndDrag()
	{
	}
}
