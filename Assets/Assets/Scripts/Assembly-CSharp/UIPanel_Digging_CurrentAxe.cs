using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_Digging_CurrentAxe : MonoBehaviour
{
	public static RectTransform s_RectTxtCurrentAxe;

	public TextMeshProUGUI txtCurrentAxe;

	public Button btnGetMoreAxe;

	public UIPopup refPopupGetMore;

	public static RectTransform s_RectIcon;

	public RectTransform icon;

	private int c_CurrentAxe;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnReadyAxeDigComplete()
	{
	}

	private void OnBuyItem(ShopHallweenDataController.ShovelShopType type)
	{
	}

	private void OnRefreshNumShovel()
	{
	}

	private void UpdateUI_CurrentAxe()
	{
	}
}
