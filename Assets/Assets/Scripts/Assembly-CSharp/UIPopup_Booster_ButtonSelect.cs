using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Booster_ButtonSelect : MonoBehaviour
{
	public Button btnSelect;

	public Sprite[] sprStateSelects;

	public Image icon;

	public RectTransform rectAmount;

	public TextMeshProUGUI txtAmount;

    public TextMeshProUGUI txtLockLevel;

    public UITimerCountdownTMP timerInfinite;

	public RectTransform rectGetMore;

	public RectTransform rectLock;

	public RectTransform rectSelected;

	public RectTransform rectFree;

	public UIPopup refPopupGetMore;

    private DataBoosterItem daBooster;

    public BoosterKind c_kind;


    bool isEnable = false;

	Action callbackBegin = null;
    int numBosster = 0;
	bool isFree = false;

    private void Start()
    {
		btnSelect.onClick.AddListener(() => {

            if(IsLockPower())
            {
                return;
            }

            if(numBosster <= 0)
            {
                UIPopup_InGame_PowerUp_GetMore.Show();
                UIPopup_InGame_PowerUp_GetMore.Instance.UpdateUiBooster(daBooster, isSuc => {
                    if(isSuc)
                    {
                        isEnable = false;
                        OnAdd();
                        numBosster++;
                        rectGetMore.gameObject.SetActive(false);
                        rectAmount.gameObject.SetActive(true);
                        txtAmount.text = numBosster.ToString();
                    }
                });
                return;
            }    

			isEnable = !isEnable;
            rectSelected.gameObject.SetActive(isEnable);

            if (isFree)
			{
                rectFree.gameObject.SetActive(!isEnable);
			}
			else
			{
                rectAmount.gameObject.SetActive(!isEnable);
            }

            UIPopup_Booster.Instance.onUpdateBooser(c_kind, isEnable);
        });
    }

    bool IsLockPower()
    {
        if (daBooster.LevelShow > HelperManager.DataPlayer.LevelID + 1)
        {
            UIPopup_Booster.Instance.RunActionUnLock($"Unlocked at Level {daBooster.LevelShow}!");
            return true;
        }

        return false;
    }

	public void OnAdd()
	{
        if(isFree)
        {
            return;
        }    
        switch (c_kind)
        {
            case BoosterKind.BreakItem:
                {
                    HelperManager.DataPlayer.BoosterKindBreakItem += !isEnable ? 1 : -1;
                    if(HelperManager.DataPlayer.BoosterKindBreakItem <= 0)
                    {
                        HelperManager.DataPlayer.BoosterKindBreakItem = 0;
                    }    
                    break;
                }

            case BoosterKind.IncreaseTime:
                {
                    HelperManager.DataPlayer.BoosterKindIncreaseTime += !isEnable ? 1 : -1;
                    if (HelperManager.DataPlayer.BoosterKindIncreaseTime <= 0)
                    {
                        HelperManager.DataPlayer.BoosterKindIncreaseTime = 0;
                    }
                    break;
                }

            case BoosterKind.X2_Star:
                {
                    HelperManager.DataPlayer.BoosterKindX2_Star += !isEnable ? 1 : -1;
                    if (HelperManager.DataPlayer.BoosterKindX2_Star <= 0)
                    {
                        HelperManager.DataPlayer.BoosterKindX2_Star = 0;
                    }
                    break;
                }
        }
    }
    bool isLock = false;

    public void SetItemData( DataSpriteBossterKind da, DataBoosterItem daPowerItem)
	{
        daBooster = daPowerItem;
        c_kind = da.Kind;
        switch (c_kind)
		{
			case BoosterKind.BreakItem:
				{
					numBosster = HelperManager.DataPlayer.BoosterKindBreakItem;
					break;
				}

            case BoosterKind.IncreaseTime:
				{
					numBosster = HelperManager.DataPlayer.BoosterKindIncreaseTime;
					break;
				}

            case BoosterKind.X2_Star:
				{
					numBosster = HelperManager.DataPlayer.BoosterKindX2_Star;
					break;
				}
        }
		icon.sprite = da.sprEnable;
		icon.SetNativeSize();
        isLock = daPowerItem.LevelShow > HelperManager.DataPlayer.LevelID + 1; ;

        if (isLock)
		{
            txtLockLevel.text = "Level " + daPowerItem.LevelShow.ToString();
            //btnSelect.enabled = false;
            rectLock.gameObject.SetActive(true);
            icon.transform.localScale = Vector3.one * 0.75f;
            rectAmount.gameObject.SetActive(false);
			//rectTimerInfinite.gameObject.SetActive(false);
			rectGetMore.gameObject.SetActive(false);
			rectSelected.gameObject.SetActive(false);
			rectFree.gameObject.SetActive(false);
            icon.gameObject.SetActive(false);
            return;
		}

        isFree = PlayerPrefs.GetInt(da.Kind.ToString(), 0) == 0;

		if(isFree)
		{
            callbackBegin = () => {
                rectFree.gameObject.SetActive(true);

                rectLock.gameObject.SetActive(false);
                rectAmount.gameObject.SetActive(false);
               // rectTimerInfinite.gameObject.SetActive(false);
                rectGetMore.gameObject.SetActive(false);
                rectSelected.gameObject.SetActive(false);
			};
		}
		else
		{
			callbackBegin = () => {
                rectGetMore.gameObject.SetActive(numBosster <= 0);
                rectAmount.gameObject.SetActive(true);
                rectFree.gameObject.SetActive(false);
                rectLock.gameObject.SetActive(false);
                //rectTimerInfinite.gameObject.SetActive(false);
                rectSelected.gameObject.SetActive(false);
            };
        }
		callbackBegin?.Invoke();
        txtAmount.text = numBosster.ToString();
    }

    private void DisableAll()
	{
	}
}
