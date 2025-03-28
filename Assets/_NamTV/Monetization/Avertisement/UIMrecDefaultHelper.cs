using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMrecDefaultHelper : MonoBehaviour
{
    private void OnEnable()
    {
        if(AdsManager.Instance != null)
            AdsManager.Instance.ShowMrectDefault(placement:this.gameObject.name.ToLower());
    }
    private void OnDisable()
    {
        if (AdsManager.Instance != null)
            AdsManager.Instance.HideMrectDefault();
    }
}
