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

	public RectTransform rectTimerInfinite;

	public UITimerCountdownTMP timerInfinite;

	public RectTransform rectGetMore;

	public RectTransform rectLock;

	public RectTransform rectSelected;

	public RectTransform rectFree;

	public UIPopup refPopupGetMore;

	private BoosterKind c_kind;

	bool isEnable = false;

	Action callbackBegin = null;
    int numBosster = 0;
	bool isFree = false;

    private void Start()
    {
		btnSelect.onClick.AddListener(() => {
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

    public void SetItemData(DataSpriteBossterKind da)
	{
		bool isLock = false;
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
        isLock = numBosster <= 0;

        if (isLock)
		{
            btnSelect.enabled = false;
            rectLock.gameObject.SetActive(true);
            icon.transform.localScale = Vector3.one * 0.75f;
            rectAmount.gameObject.SetActive(false);
			rectTimerInfinite.gameObject.SetActive(false);
			rectGetMore.gameObject.SetActive(false);
			rectSelected.gameObject.SetActive(false);
			rectFree.gameObject.SetActive(false);
			icon.sprite = da.sprDisable;
            return;
		}

        isFree = true;

		if(isFree)
		{
            callbackBegin = () => {
                rectFree.gameObject.SetActive(true);

                rectLock.gameObject.SetActive(false);
                rectAmount.gameObject.SetActive(false);
                rectTimerInfinite.gameObject.SetActive(false);
                rectGetMore.gameObject.SetActive(false);
                rectSelected.gameObject.SetActive(false);
			};
		}
		else
		{
			callbackBegin = () => {
                rectAmount.gameObject.SetActive(true);
                rectFree.gameObject.SetActive(false);
                rectLock.gameObject.SetActive(false);
                rectTimerInfinite.gameObject.SetActive(false);
                rectGetMore.gameObject.SetActive(false);
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
