using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMenuCellDetail : MonoBehaviour
{
	[SerializeField]
	private GameObject _parentContent;

	[SerializeField]
	private TMP_InputField _inputFieldSpeed;

	[SerializeField]
	private TMP_Dropdown _dropDownMovePanelType;

	[SerializeField]
	private Toggle toggle;

	private int _cacheDropdown;

	private float _cacheSpeed;

	private GoodSortEditorCell _cell => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void ActiveDetail()
	{
	}

	private void DeactiveDetail()
	{
	}

	private void OnChangeType(int index)
	{
	}

	private void OnChangeCellSpeed(string newValue)
	{
	}

	private void OnChangeCellLock(bool newValue)
	{
	}

	private void SetupMovePanelType()
	{
	}
}
