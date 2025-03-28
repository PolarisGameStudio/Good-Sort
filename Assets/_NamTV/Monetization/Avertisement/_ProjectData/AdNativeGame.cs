using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AdNativeGame : MonoBehaviour
{
    [SerializeField] GameObject nativeHomeParent;
    [SerializeField] AdmobNativePanel nativeHome;
    public bool UseNativeBanner => AdsManager.Instance.UseNative && !GameNativeHandle.Instance.useOrganic;
    public static AdNativeGame Instance;
    bool canShow = false;
    private void Start()
    {
        if (UseNativeBanner)
        {
            nativeHome._OnNativeClick += () =>
            {
                Debug.Log("AdsManager NativeHome Click");
                RequestNativeHome();
            };
            nativeHome._OnRequireReload += () =>
            {
                RequestNativeHome();
            };
        }
        SetNativeHomeParent();
    }
    void RequestNativeHome()
    {
        Debug.Log("AdsManager RequestNativeHome");
        AdsManager.Instance.RequestNativeAds(nativeHome);
    }
    public void SetNativeHomeParent(Transform _parent = null)
    {
        if(_parent != null)
        {
            RequestNativeHome();
            nativeHomeParent.transform.SetParent(_parent);
            canShow = true;
            ShowNativeHome(true);
        }
        else
        {
            nativeHomeParent.transform.SetParent(this.transform);
            canShow = false;
            ShowNativeHome(false);
        }
    }
    public void ShowNativeHome(bool show)
    {
        nativeHomeParent.SetActive(/*canShow && */show);
    }
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this.nativeHomeParent);
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

}
