using UnityEngine;
using DG.Tweening;
using System.Linq;
using UnityEngine.UI;
using TMPro;
using System;

public class AdsLoading : MonoBehaviour
{
    [Header("Images - Use this to change your loading game")]
    [SerializeField] GameObject teaBrakeObject;
    [SerializeField] protected Image loadingImage = null;
    //[SerializeField] protected AspectRatioFitter aspectRatioFitter;
#if UNITY_EDITOR
    [SerializeField] protected Sprite[] spriteInReoucesFolder;
#endif
    [HideInInspector] public string[] loadingSpriteInReoucesFolder;
    protected int loadingSpriteIndex = 0;

    [Header("Messages")]
    [SerializeField] protected TextMeshProUGUI message = null;
    [SerializeField] protected bool isToUpperCase = false;
    [SerializeField] protected string[] messages;
    protected int messageIndex = 0;
    public static string messageDefault = "We apologize for any inconvenience the advertisement may cause!";

    [Header("Custom")]
    [SerializeField] protected GameObject content = null;
    [SerializeField] protected GameObject loadingObject = null;
    [SerializeField] protected Slider loadingSlider = null;

    public float precent => loadingSlider.value;

    public static AdsLoading instance = null;

    public Action<string> callbackSetText;

    private void Awake()
    {
        instance = this;
        if (content)
            content.SetActive(false);
        if (loadingSlider)
            loadingSlider.value = 0;
    }



    public static void ShowNotice(string message, float durationAutoHide = 1.5f)
    {
        if (instance != null)
        {
            Debug.Log("AdsLoading ShowNotice");
            instance.DOShow(message, durationAutoHide, false, false);
        }
        else
        {
            Debug.LogWarning("AdsLoading NULL");
        }
    }

    public static void ShowLoading(string message, float durationAutoHide = 3.0f, bool showLoadingImage = true, bool showAdsBrake = false)
    {
        if (instance != null)
        {
            Debug.Log("AdsLoading ShowLoading");
            instance.DOShow(message, durationAutoHide, showLoadingImage, showAdsBrake);
        }
        else
        {
            Debug.LogWarning("AdsLoading NULL");
        }
    }

    public static void SetUpdate(string message, float process, float durationTime, bool showLoadingImage)
    {
        Debug.Log("Message");
        if (instance)
        {
            instance.content.SetActive(true);
            instance.loadingObject.SetActive(showLoadingImage);
            instance.message.text = instance.isToUpperCase ? message.ToUpper() : message;
            instance.loadingSlider.DOKill();
            instance.loadingSlider.DOValue(process, durationTime).SetEase(Ease.Linear);
            instance.callbackSetText?.Invoke(message);
        }
    }

    public void DOShow(string message, float durationAutoHide, bool showLoadingImage, bool showAdsBrake)
    {
        if (showLoadingImage && loadingSpriteInReoucesFolder != null && loadingSpriteInReoucesFolder.Length > 0)
        {
            loadingSpriteIndex %= loadingSpriteInReoucesFolder.Length;
            var sprite = Resources.Load<Sprite>(loadingSpriteInReoucesFolder[loadingSpriteIndex]);
            loadingImage.sprite = sprite;
            loadingSpriteIndex++;
        }
        if (teaBrakeObject != null)
            teaBrakeObject.SetActive(showAdsBrake);
        loadingObject.SetActive(showLoadingImage);
        //if (loadingImage.sprite)
        //    aspectRatioFitter.aspectRatio = loadingImage.sprite.rect.width / loadingImage.sprite.rect.height;

        if (string.IsNullOrEmpty(message) && messages != null && messages.Length > 0)
        {
            messageIndex %= messages.Length;
            message = messages[messageIndex];
            messageIndex++;
        }

        if (!string.IsNullOrEmpty(message))
            this.message.text = isToUpperCase ? message.ToUpper() : message;
        else
            this.message.text = isToUpperCase ? messageDefault.ToUpper() : messageDefault;

        content.SetActive(true);

        loadingSlider.DOKill();
        loadingSlider.DOValue(1, durationAutoHide)
            .SetEase(Ease.Linear)
            .OnComplete(() =>
            {
                Hide();
            });
    }

    protected void Hide(float durationTime = 0.25f)
    {
        loadingSlider.DOKill();
        if (loadingSlider.value != 1)
        {
            loadingObject.SetActive(false);
            loadingSlider.DOValue(1, durationTime)
                .SetUpdate(UpdateType.Normal, true)
                .SetEase(Ease.OutCubic)
                .OnComplete(() =>
                {
                    loadingSlider.value = 0;
                    content.SetActive(false);
                });
        }
        else
        {
            loadingSlider.value = 0;
            loadingObject.SetActive(false);
            content.SetActive(false);
        }
    }

    public static void HideLoading(string message = null)
    {
        if (instance != null)
        {
            Debug.Log("AdsLoading HideLoading");
            if (string.IsNullOrEmpty(message))
                message = messageDefault;
            instance.message.text = instance.isToUpperCase ? message.ToUpper() : message;
            instance.Hide();
        }
        else
        {
            Debug.LogWarning("AdsLoading NULL");
        }
    }
}