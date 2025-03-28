using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ReciverStar : MonoBehaviour
{
    [Header("SoReciverItem")]
    public SoReciverItem soReciverItem;
    public SkeletonGraphic skeChes = null;

    [Header("Progress Level")]
    public Slider progressLevel = null;
    public TextMeshProUGUI txtMeshComplete = null;

    public Button btnClaim = null;

    void Start()
    {
        OnUpdateUi(false);
        soReciverItem.SetRetype();
    }

    public void OnUpdateUi(bool isRunAnim)
    {
        var starLimit = soReciverItem.GetStarLimit(HelperManager.DataPlayer.IndexStarLimit);
        txtMeshComplete.text = $"{HelperManager.DataPlayer.TotalStar} / {starLimit}";
        float per = (float)HelperManager.DataPlayer.TotalStar / (float)starLimit;
        if(isRunAnim)
        {
            progressLevel.DOValue(per, 0.25f);
        }
        else
        {
            progressLevel.value = per;
        }

        if (per >= 1.0f)
        {
            btnClaim.enabled = true;
            btnClaim.onClick.AddListener(() =>
            {
                ShowRewardStar();
            });

        }
        else
        {
            btnClaim.enabled = false;
        }
    }    

    public void ShowRewardStar()
    {
        HelperManager.DataPlayer.IndexStarLimit++;
        var da = soReciverItem.GetDataSoReciverItemByStarAdd(HelperManager.DataPlayer.TotalStar);
        if (da.starLimit == -1)
        {
            return;
        }
        UIPopup_UnlockRewards.Show();
        UIPopup_UnlockRewards.Instance.UpdateUI_SkeletonChest(skeChes, da.reciverItems1, 0.01f, 0.425f, 0.25f, () =>
        {
            MainMenu.Instance.RunAnim();
            OnUpdateUi(true);
        });
    }

    public void OnClickClamin()
    {

    }   
}
