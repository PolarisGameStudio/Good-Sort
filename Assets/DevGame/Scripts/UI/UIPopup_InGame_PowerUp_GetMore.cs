using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_InGame_PowerUp_GetMore : MonoBehaviour
{
	public Image icon;

	public TextMeshProUGUI txtDes;

	public Button btnBuy;

	public TextMeshProUGUI txtPrice;

	public Button btnWatchAd;

	public Transform btnBuyByGoldContainer;

	public Transform btnWatchAdContainer;

	public TextMeshProUGUI txtFreeAds;

	private Vector3 _posBtnBuyByGold;

	private Vector3 _posBtnWatch;

	private void Awake()
	{
	}

	private void Active(bool both)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void UpdateUI(PowerupKind kind)
	{
	}
}
