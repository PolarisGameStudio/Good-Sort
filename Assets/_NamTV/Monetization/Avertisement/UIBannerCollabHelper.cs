using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBannerCollabHelper : MonoBehaviour
{
    private void OnEnable()
    {
        if(AdBannerFakeCollab.Instance)
            AdBannerFakeCollab.Instance._HideBanner();
    }
}
