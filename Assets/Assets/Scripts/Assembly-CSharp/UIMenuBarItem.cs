using UnityEngine;
using UnityEngine.UI;

public class UIMenuBarItem : MonoBehaviour
{
	[SerializeField]
	private RectTransform _previewParent;

	[SerializeField]
	private GameObject _prefabPreviewImage;

	private GameObject _prefab;

	public ItemType itemType;

	private SpriteRenderer[] _spritesToPreview;

	private float _pixel;

	private Vector3 _defaultScaleParentPreview;

	[SerializeField]
	private Button _button;

	private void Awake()
	{
	}

	public void SetupPreview(GameObject item)
	{
	}

	public void OnClickAddItemSelected()
	{
	}

	public void OnClickAddItemSelectedWithoutCallback()
	{
	}
}
