using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_InGame_EventPVP_PowerUpBar_Item : MonoBehaviour
{
	public enum ItemState
	{
		Lock = 0,
		CanUseFree = 1,
		CanUse = 2,
		CanBuyByGold = 3,
		NotEnoughGold = 4
	}

	[SerializeField]
	private Image _icon;

	[SerializeField]
	private Button _btnClick;

	[SerializeField]
	private GameObject _bgLock;

	[SerializeField]
	private GameObject _bgCanUseFree;

	[SerializeField]
	private GameObject _bgCanUse;

	[SerializeField]
	private GameObject _bgCanBuy;

	[SerializeField]
	private GameObject _bgNotEnoughGold;

	[SerializeField]
	private TextMeshProUGUI _txtNum;

	[SerializeField]
	private TextMeshProUGUI[] _txtPrices;

	private UI_InGame_EventPVP_PowerUpBar _powerUpBar;

	private PowerupKind _kind;

	public PowerupKind Kind => default(PowerupKind);

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void UpdateUI(PowerupKind kind, UI_InGame_EventPVP_PowerUpBar powerUpBar)
	{
	}

	private void DefaultState()
	{
	}

	private void UpdateState(PowerupKind kind)
	{
	}

	private ItemState GetItemState(PowerupKind kind)
	{
		return default(ItemState);
	}

	private void OnClick()
	{
	}
}
