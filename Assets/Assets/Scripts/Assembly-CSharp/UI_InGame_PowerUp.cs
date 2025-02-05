using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_InGame_PowerUp : MonoBehaviour
{
	public Button[] btnSelects;

	public Image[] icons;

	public TextMeshProUGUI[] txtNumbers;

	public RectTransform[] rectIconMores;

	public RectTransform[] rectIconLocks;

	public RectTransform[] rectIconFrees;

	public UITutorialSystem uiTutorialPowerUp;

	private void Start()
	{
	}

	private void OnPurchaseSusscess(string obj)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnUILoadingDone()
	{
	}

	private void UpdateUI()
	{
	}

	private void UpdateUI_SlotPowerUp(PowerupKind kind)
	{
	}

	private int GetIndexPowerUp(PowerupKind kind)
	{
		return 0;
	}

	private void UpdateUI_LockItem(PowerupKind kind)
	{
	}
}
