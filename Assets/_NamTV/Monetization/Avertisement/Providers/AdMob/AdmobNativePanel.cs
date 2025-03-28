using GoogleMobileAds.Api;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AdmobNativePanel : MonoBehaviour
{
#if USE_ADMOB_NATIVE
    public AdmobNativeType admobNativeType = AdmobNativeType.Default;
    [SerializeField] protected GameObject containter;
    [SerializeField] protected TextMeshProUGUI adHeadLine;
    [SerializeField] protected int adHeadLineMaxLenght = 24;
    [SerializeField] protected TextMeshProUGUI advertiser;
    [SerializeField] protected TextMeshProUGUI adBody;
    [SerializeField] protected int adBodyMaxLenght = 256;
    [SerializeField] protected Image adIcon;
    [SerializeField] protected Sprite adIconSprite;
    [SerializeField] protected AspectRatioFitter adIconAspectRatioFitter;
    [SerializeField] protected Vector2Int iconMaxSize = new Vector2Int(50, 50);
    [SerializeField] protected Image adChoice;
    [SerializeField] protected Image adImage;
    [SerializeField] protected Sprite adImageSprite;
    [SerializeField] protected AspectRatioFitter adImageAspectRatioFitter;
    [SerializeField] protected Vector2Int adImageMaxSize = new Vector2Int(200, 200);
    [SerializeField] protected BoxCollider2D adImageCollider;
    [SerializeField] protected GameObject callToAction;
    [SerializeField] protected TextMeshProUGUI callToActionText;

    [Header("For App Install")]
    [SerializeField] protected GameObject installGroup;
    [SerializeField] protected Image starRatingFill;
    [SerializeField] protected TextMeshProUGUI store;
    [SerializeField] protected TextMeshProUGUI price;
    [Header("For close")]
    [SerializeField] bool useCloseBtn;
    [SerializeField] bool useDelayClose;
    [SerializeField] Button closeBtn;
    [SerializeField] TextMeshProUGUI closeTxt;
    [SerializeField] int timeDelay = 5;
    [SerializeField] List<UIAnimBase> anim = new List<UIAnimBase>();
    [SerializeField] bool useAutoClose = false;
    [SerializeField] float autoClosetime = 8.6f;


    [HideInInspector] public bool isLoading = false;
    public Action _OnNativeClick;
    public Action _OnNativeLoaded;
    public Action _OnNativeClose;
    public Action _OnRequireReload;
    public bool canShow = false;
    [SerializeField] float originSizeW = 2500f;
    [SerializeField] float originSizeH = 600;
    [SerializeField] float fakeSizeW = 2500f;
    [SerializeField] float fakeSizeH = 600;
    public bool useFakeCollider = false;
    [SerializeField] bool useScaleSize = true;

    float timeShowCount = 0;
    float timeReloadNative = 15f;
    bool isShowing = false;
    private void Start()
    {
        if (useCloseBtn && closeBtn != null)
        {
            closeBtn.onClick.RemoveAllListeners();
            closeBtn.onClick.AddListener(OnClose);
        }
    }
    private void OnEnable()
    {
        timeShowCount = 0;
        isShowing = true;
        if(useCloseBtn)
        {
            closeBtn.interactable = !useFakeCollider;
            if (useDelayClose)
                StartCoroutine(ShowCloseButton());
        }
    }
    int _tempCount = 0;
    private IEnumerator ShowCloseButton()
    {
        closeBtn.interactable = false;
        _tempCount = timeDelay;
        while (_tempCount > 0) {
            closeTxt.text = "Skip ads in " + (_tempCount).ToString();
            _tempCount--;
            yield return new WaitForSeconds(1.0f);
        }
        closeTxt.text = string.Empty;
        closeBtn.interactable = true;
        
    }
    private void OnDisable()
    {
        isShowing = false;
    }
    private void Update()
    {
        if (!isShowing) return;
        if (!useCloseBtn)
        {
            timeShowCount += Time.deltaTime;
            if (timeShowCount > timeReloadNative)
            {
                timeShowCount = 0;
                _OnRequireReload?.Invoke();
            }
        }
        if (useAutoClose)
        {
            timeShowCount += Time.deltaTime;
            if(timeShowCount > autoClosetime)
            {
                timeShowCount = 0;
                OnClose();
            }
        }
    }
    public void ShowContent(bool canShow)
    {
        if (containter)
            containter.SetActive(canShow);
    }
    public void OnLoaded()
    {
        if (isShowing)
        {
            if(anim != null)
            {
                foreach(var _anim in anim)
                {
                    _anim.Show();
                }
            }
        }
        canShow = true;
        _OnNativeLoaded?.Invoke();
    }
    public void OnClose()
    {
        canShow = false;
        _OnNativeClose?.Invoke();
        gameObject.SetActive(false);
    }
    public void OnClick()
    {
        if(closeBtn)
            closeBtn.interactable = true;
        canShow = false;
        _OnNativeClick?.Invoke();
        if(adImageCollider != null)
            adImageCollider.GetComponent<Image>().raycastTarget = false;
    }  
    public void _HandleRequestNativeAds(List<string> _ID, bool reset = true)
    {
        if(isLoading) return;
        isLoading = true;
        if (reset)
        {
            currentNativeRetry = 0;
        }
        if (_ID.Count <= currentNativeRetry) return;
        FirebaseLogHandle.OnAdsCall("native_" + admobNativeType.ToString().ToLower());
        AdLoader adLoader = new AdLoader.Builder(_ID[currentNativeRetry])
            .ForNativeAd()
            .Build();
        adLoader.OnNativeAdLoaded += (object sender, NativeAdEventArgs args) =>
        {
            FirebaseLogHandle.OnAdsLoaded("native_" + admobNativeType.ToString().ToLower());
            GoogleMobileAds.Common.MobileAdsEventExecutor.ExecuteInUpdate(() =>
            {
                SetNativeAds(args.nativeAd);
                OnLoaded();
                isLoading = false;
            });
        };
        adLoader.OnAdFailedToLoad += (object sender, AdFailedToLoadEventArgs e) =>
        {
            if (currentNativeRetry < _ID.Count - 1)
            {
                currentNativeRetry++;
                _HandleRequestNativeAds(_ID, false);
            }
            else
            {
                isLoading = false;
            }
        };
        adLoader.OnNativeAdClicked += (object sender, EventArgs args) =>
        {
            OnClick();
            AdsManager.Instance.ResetInterstitialDelayTime();
        };
        adLoader.OnNativeAdImpression += (object sender, EventArgs args) =>
        {
            GoogleMobileAds.Common.MobileAdsEventExecutor.ExecuteInUpdate(() =>
            {
                //FirebaseLogger.NativeImpression(_ID[currentNativeRetry]);
            });
        };
        adLoader.LoadAd(new AdRequest());
    }
    private int currentNativeRetry;
    private void SetNativeAds(NativeAd nativeAd)
    {
        nativeAd.OnPaidEvent += OnPaidEvent;
        bool successRegister;
        if (adIcon)
        {
            Texture2D iconTexture = nativeAd.GetIconTexture();
            if (iconTexture)
            {
                iconTexture.name = "iconTexture_" + admobNativeType.ToString();
                var ratio = iconTexture.width * 1f / iconTexture.height;
                if (iconTexture.width > iconMaxSize.x || iconTexture.height > iconMaxSize.y)
                    iconTexture = Resize(iconTexture, Mathf.FloorToInt(iconMaxSize.x * ratio), iconMaxSize.y);

                adIcon.sprite = Sprite.Create(iconTexture, new Rect(0, 0, iconTexture.width, iconTexture.height), new Vector2(0.5f, 0.5f));
                adIcon.preserveAspect = true;
            }
            else
            {
                adIcon.sprite = adIconSprite;
            }

            if (adIconAspectRatioFitter != null)
                adIconAspectRatioFitter.aspectRatio = 1;
        }
        //yield return new WaitForEndOfFrame();
        if (adHeadLine)
        {
            string headlineText = nativeAd.GetHeadlineText();
            if (string.IsNullOrEmpty(headlineText))
                headlineText = "Thank for playing out game";

            if (headlineText.Length > adHeadLineMaxLenght)
                adHeadLine.text = headlineText.Substring(0, adHeadLineMaxLenght).ToUpper() + "...";
            else
                adHeadLine.text = headlineText.ToUpper();
        }
        //yield return new WaitForEndOfFrame();
        if (adBody)
        {
            string bodyText = nativeAd.GetBodyText();
            if (string.IsNullOrEmpty(bodyText))
                bodyText = "We apologize for any inconvenience the advertisement may cause!";

            if (bodyText.Length > adBodyMaxLenght)
                adBody.text = bodyText.Substring(0, adBodyMaxLenght) + "...";
            else
                adBody.text = bodyText;
        }
        //yield return new WaitForEndOfFrame();
        if (advertiser)
        {
            string advertiserText = nativeAd.GetAdvertiserText();
            if (string.IsNullOrEmpty(advertiserText))
                advertiserText = "Google AdMob";
            advertiser.text = advertiserText;
        }
        //yield return new WaitForEndOfFrame();
        if (callToActionText)
        {
            string ctaText = nativeAd.GetCallToActionText();
            callToActionText.text = ctaText.ToUpper();
        }
        //yield return new WaitForEndOfFrame();
        if (adChoice)
        {
            Texture2D adChoiceTexture = nativeAd.GetAdChoicesLogoTexture();
            if (adChoiceTexture != null)
            {
                adChoiceTexture.name = "adChoiceTexture_" + admobNativeType.ToString();

                adChoice.sprite = Sprite.Create(adChoiceTexture, new Rect(0, 0, adChoiceTexture.width, adChoiceTexture.height), new Vector2(0.5f, 0.5f));
                adChoice.preserveAspect = true;
                adChoice.gameObject.SetActive(true);
            }
            else
            {
                adChoice.gameObject.SetActive(false);
            }
        }
        //yield return new WaitForEndOfFrame();
        if (adImage)
        {
            List<Texture2D> adImageTextures = nativeAd.GetImageTextures();
            if (adImageTextures != null && adImageTextures.Count > 0)
            {
                foreach (var texture in adImageTextures)
                    texture.name = "adImageTexture_" + texture.width + "x" + texture.height + "_" + admobNativeType.ToString();

                Texture2D adImageTexture = adImageTextures.FirstOrDefault();

                if (adImage != null && adImageTexture != null)
                {
                    var ratio = adImageTexture.width * 1f / adImageTexture.height;
                    //Log(TAG, adImageTexture.name + " " + adImageTexture.width + "x" + adImageTexture.height + "px" + " ratio " + ratio + " total " + adImageTextures.Count);

                    if (adImageTexture.width > adImageMaxSize.x || adImageTexture.height > adImageMaxSize.y)
                        adImageTexture = Resize(adImageTexture, Mathf.FloorToInt(adImageMaxSize.x * ratio), adImageMaxSize.y);

                    if (adImageAspectRatioFitter != null)
                        adImageAspectRatioFitter.aspectRatio = ratio;
                    adImage.sprite = Sprite.Create(adImageTexture, new Rect(0, 0, adImageTexture.width, adImageTexture.height), new Vector2(0.5f, 0.5f));

                    if (adIcon && adIcon.sprite == adIconSprite)
                    {
                        if (adIconAspectRatioFitter != null)
                            adIconAspectRatioFitter.aspectRatio = ratio;
                        adIcon.sprite = adImage.sprite;
                    }
                }
                else
                {
                    if (adImageSprite)
                    {
                        if (adIconAspectRatioFitter != null)
                            adIconAspectRatioFitter.aspectRatio = adImageSprite.texture.width * 1f / adImageSprite.texture.height;
                        adImage.sprite = adImageSprite;
                    }
                }
            }
            else
            {
                //LogWarning(TAG, "AdImageTextures is null");
            }
        }
        //yield return new WaitForEndOfFrame();
        if (adIcon)
        {
            //successRegister = nativeAd.RegisterIconImageGameObject(adIcon.gameObject);
            //if (!successRegister)
            //    LogWarning(TAG, "Failed to register Icon");
        }
        if (adHeadLine)
        {
            //successRegister = nativeAd.RegisterHeadlineTextGameObject(adHeadLine.gameObject);
            //if (!successRegister)
            //    LogWarning(TAG, "Failed to register Headline");
        }
        if (adBody)
        {
            //successRegister = nativeAd.RegisterBodyTextGameObject(adBody.gameObject);
            //if (!successRegister)
            //    LogWarning(TAG, "Failed to register Body");
        }
        //yield return new WaitForEndOfFrame();

        if (callToAction)
        {
            //successRegister = nativeAd.RegisterCallToActionGameObject(callToAction);
            //if (!successRegister)
            //    LogWarning(TAG, "Failed to register CallToAction");
        }

        //yield return new WaitForEndOfFrame();

        if (adChoice)
        {
            //successRegister = nativeAd.RegisterAdChoicesLogoGameObject(adChoice.gameObject);
            //if (!successRegister)
            //    LogWarning(TAG, "Failed to register AdChoice");
        }

        //yield return new WaitForEndOfFrame();

        if (advertiser)
        {
            //successRegister = nativeAd.RegisterAdvertiserTextGameObject(advertiser.gameObject);
            //LogWarning(TAG, "Failed to register Advertiser");
        }

        //yield return new WaitForEndOfFrame();

        if (adImage)
        {
            int successImage = nativeAd.RegisterImageGameObjects(new List<GameObject> { adImage.gameObject });
            if (adImageCollider)
            {
                if (useFakeCollider)
                    adImageCollider.size = new Vector2(GetWidthSize(fakeSizeW, useScaleSize), GetHeightSize(fakeSizeH, useScaleSize));
                else
                    adImageCollider.size = new Vector2(GetWidthSize(originSizeW, useScaleSize), GetHeightSize(originSizeH, useScaleSize));
                adImageCollider.GetComponent<Image>().raycastTarget = true;
                if (successImage == 0)
                    Debug.Log("[AdsManager]:" + this.admobNativeType + " Failed to register adImageCollider " + adImageCollider.size);
                else
                {
                    Debug.Log("[AdsManager]:" + this.admobNativeType + " Sucess adImageCollider " + adImageCollider.size);
                }
            }
            
            
            
        }
        else if (adImageCollider)
        {
            int successImage = nativeAd.RegisterImageGameObjects(new List<GameObject> { adImageCollider.gameObject });
            if (useFakeCollider)
                adImageCollider.size = new Vector2(GetWidthSize(fakeSizeW,useScaleSize), GetHeightSize(fakeSizeH,useScaleSize));
            else
                adImageCollider.size = new Vector2(GetWidthSize(originSizeW, useScaleSize), GetHeightSize(originSizeH, useScaleSize));
            adImageCollider.GetComponent<Image>().raycastTarget = true;
            
            if (successImage == 0)
                Debug.Log("[AdsManager]:" + this.admobNativeType + " Failed to register adImageCollider " + adImageCollider.size);
            else
            {
                Debug.Log("[AdsManager]:" + this.admobNativeType + " Sucess adImageCollider " + adImageCollider.size);
            }

        }

        //yield return new WaitForEndOfFrame();

        //// For App Install
        if (installGroup)
        {
            string storeTitle = nativeAd.GetStore();
            if (!string.IsNullOrEmpty(storeTitle))
            {
                installGroup.SetActive(true);
                store.text = storeTitle;
                //successRegister = nativeAd.RegisterStoreGameObject(store.gameObject);
                //if (!successRegister)
                //    LogWarning(TAG, "Failed to register store");
            }

            double storeStarRating = nativeAd.GetStarRating();
            if (storeStarRating is double.NaN || storeStarRating <= 0)
                storeStarRating = UnityEngine.Random.Range(4.0f, 4.5f);
            starRatingFill.fillAmount = (float)(storeStarRating * 0.2f);

            string storePrice = nativeAd.GetPrice();
            if (string.IsNullOrEmpty(storePrice))
                storePrice = "FREE";
            price.text = storePrice;

            //successRegister = nativeAd.RegisterPriceGameObject(price.gameObject);
            //if (!successRegister)
            //    LogWarning(TAG, "Failed to register price");
        }
        gameObject.SetActive(true);
    }
    
    public float GetHeightSize(float bannerSizeH, bool scaleSize = true)
    {
        //float _bannerHeight = bannerSizeH * (Screen.safeArea.height / 1920);
        float _height = Screen.safeArea.height > Screen.safeArea.width ? 1920 : 1080;
        if (scaleSize)
            return bannerSizeH * (Screen.safeArea.height / _height);
        else
            return bannerSizeH;
    }
    public float GetWidthSize(float width, bool scaleSize = true)
    {
        float _width = Screen.safeArea.height > Screen.safeArea.width ? 1080 : 1920;
        if (scaleSize)
            return width * (Screen.safeArea.width / _width);
        else
            return width;
    }
    void OnPaidEvent(object sender, AdValueEventArgs e)
    {
        UnityMainThreadDispatcher.Enqueue(() =>
        {
            AdsManager.Instance.OnAdPaid("native_" + admobNativeType.ToString().ToLower(), e.AdValue);
        });
    }
    Texture2D Resize(Texture2D texture, int newWidth, int newHeight)
    {
        RenderTexture tmp = RenderTexture.GetTemporary(newWidth, newHeight, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
        RenderTexture.active = tmp;
        Graphics.Blit(texture, tmp);
#if UNITY_2021_3_OR_NEWER
        texture.Reinitialize(newWidth, newHeight, texture.format, false);
#else
            texture.Resize(newWidth, newHeight, texture.format, false);
#endif
        texture.filterMode = FilterMode.Bilinear;
        texture.ReadPixels(new Rect(Vector2.zero, new Vector2(newWidth, newHeight)), 0, 0);
        texture.Apply();
        RenderTexture.ReleaseTemporary(tmp);
        return texture;
    }
#endif
}
