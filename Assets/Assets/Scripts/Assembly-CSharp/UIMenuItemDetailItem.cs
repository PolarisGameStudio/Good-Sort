using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMenuItemDetailItem : MonoBehaviour
{
	[SerializeField]
	private RectTransform _previewParent;

	[SerializeField]
	private GameObject _prefabPreviewImage;

	[SerializeField]
	private TextMeshProUGUI _txtNumber;

	[SerializeField]
	private Button _buttonDelete;

	private GameObject _prefab;

	private SpriteRenderer[] _spritesToPreview;

	private float _pixel;

	private Vector3 _defaultScaleParentPreview;

	private void Awake()
	{
	}

	private void SetupEventTrigger()
	{
	}

	public void SetupPreview(GameObject item, int num)
	{
	}

	public void DeleteItem()
	{
	}

	public void UpdateNum(int num)
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
