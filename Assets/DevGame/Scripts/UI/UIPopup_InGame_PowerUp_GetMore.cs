using DG.Tweening;
using Spine;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_InGame_PowerUp_GetMore : Dialog<UIPopup_InGame_PowerUp_GetMore>
{
	public Image icon;

	public TextMeshProUGUI txtDes;

	public Button btnBuy;

	public TextMeshProUGUI txtPrice;

	public Button btnWatchAd;

    public Button btnExit;

    Action<bool> currentCallbackk;
    Action<bool> callbackStart;

    public TextMeshProUGUI txtTitle;
    public TextMeshProUGUI txtAdd;

    public ShowToas showToas;

    int price = 0;

    private void Start()
    {
        btnBuy.onClick.AddListener(() =>
        {
            if(!OnPrice())
            {
                return;
            }
            currentCallbackk?.Invoke(true);
            onClose();
        });
        btnWatchAd.onClick.AddListener(() =>
        {
            currentCallbackk?.Invoke(true);
            onClose();
        });
        btnExit.onClick.AddListener(() =>
        {
            OnCallbackFail();
            onClose();
        });
    }

    private void OnCallbackFail()
    {
        currentCallbackk?.Invoke(false);
    }    

    public void UpdateUI(DataPowerItem power, Action<bool> Callback, Action<bool> _callbackStar)
	{
        callbackStart = _callbackStar;
        callbackStart?.Invoke(true);
        currentCallbackk = Callback;
        ResourceType re = ResourceType.Powerup_BreakItem;
        if (power.kind == PowerupKind.BreakItem)
        {
            re = ResourceType.Powerup_BreakItem;
        }

        if (power.kind == PowerupKind.Replace)
        {
            re = ResourceType.Powerup_Replace;
        }

        if (power.kind == PowerupKind.Freeze)
        {
            re = ResourceType.Powerup_Freeze;
        }

        if (power.kind == PowerupKind.Swap)
        {
            re = ResourceType.Powerup_Swap;
        }
        price = power.price;
        txtPrice.text = price.ToString();
        icon.sprite = UISpriteController.Instance.GetSpriteResource(re);
        icon.SetNativeSize();
        txtDes.text = power.textDes;
        txtPrice.text = power.price.ToString();
        txtTitle.text = "Booster";
        txtAdd.gameObject.SetActive(true);

    }

    public bool OnPrice()
    {
        if(HelperManager.DataPlayer.TotalCoin < price)
        {
            showToas.RunActionToas();
            return false;
        }
        HelperManager.OnAddTotalCoin(-price);
        return true;
    }

    public void UpdateUiBooster(DataBoosterItem power, Action<bool> Callback)
    {
        currentCallbackk = Callback;
        ResourceType re = ResourceType.Powerup_BreakItem;

        if (power.kind == BoosterKind.BreakItem)
        {
            re = ResourceType.Booster_BreakItem;
        }

        if (power.kind == BoosterKind.IncreaseTime)
        {
            re = ResourceType.Booster_Time;
        }

        if (power.kind == BoosterKind.X2_Star)
        {
            re = ResourceType.Booster_X2_Star;
        }

        price = power.price;
        txtPrice.text = price.ToString();
        icon.sprite = UISpriteController.Instance.GetSpriteResource(re);
        icon.SetNativeSize();
        txtDes.text = power.textDes;
        txtPrice.text = power.price.ToString();

    }

    public static void Show()
    {
        Open();
    }
    public static void Hide()
    {
        Close();
    }

    public void onClose()
    {
        callbackStart?.Invoke(false);
        Hide();
    }
}
