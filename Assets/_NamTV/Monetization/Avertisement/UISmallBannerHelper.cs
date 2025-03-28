using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISmallBannerHelper : MonoBehaviour
{
    [SerializeField] bool showOnEnable = true;
    private void OnEnable()
    {
        if (AdsManager.Instance)
        {
            if (showOnEnable)
                AdsManager.Instance.ShowSmallBanner();
            else
                AdsManager.Instance.HideSmallBanner();
        }
    }
    private void OnDisable()
    {
        if (AdsManager.Instance)
        {
            if (showOnEnable)
                AdsManager.Instance.HideSmallBanner();
            else
                AdsManager.Instance.ShowSmallBanner();
        }
    }
}
