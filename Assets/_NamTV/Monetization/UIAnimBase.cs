using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAnimBase : MonoBehaviour
{
    public bool useFade = false;
    [Header("Anim In")]
    [SerializeField] bool playonEnable = false;
    [SerializeField] protected Ease easeIn = Ease.OutCubic;
    [SerializeField] protected float timeIn = 0.25f;
    [SerializeField] protected Vector2 offsetIn = Vector2.one;
    public float delayIn = 0;
    [Header("Anim Out")]
    [SerializeField] protected Ease easeOut = Ease.InCubic;
    [SerializeField] protected float timeOut = 0.175f;
    [SerializeField] protected Vector2 offsetOut = Vector2.one;
    [SerializeField] protected float delayOut = 0;
    protected Vector2 orginPos = Vector2.zero;
    protected RectTransform rectTransform;
    protected Action actionOnHideCompleted;
    public bool playWithParent = false;
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        orginPos = rectTransform.localPosition;
    }
    protected virtual void OnDisable()
    {
        rectTransform.DOKill(complete: true);
    }
    protected virtual void OnEnable()
    {
        if (rectTransform == null) return;
        if (playonEnable)
        {
            Show();
        }
    }

    public void PreAnimIn()
    {
        rectTransform.DOKill(complete: true);
        rectTransform.localPosition = orginPos + offsetIn;
        if (useFade)
            rectTransform.localScale = Vector3.zero;
    }
    public void AnimIn(Action onComplete = null)
    {
        //rectTransform.DOKill(complete: true);
        //rectTransform.anchoredPosition = orginPos + offsetIn;
        Vector2 tempPos = rectTransform.localPosition;
        float tempVal = 0;
        DOTween.To(() => tempVal, (x) =>
        {
            if (useFade)
                rectTransform.localScale = Vector3.one * x;
            rectTransform.localPosition = Vector2.Lerp(tempPos, orginPos, x);
        }, 1, timeIn).SetDelay(delayIn).SetEase(easeIn).SetUpdate(UpdateType.Normal, isIndependentUpdate: true).SetTarget(rectTransform)
        .OnComplete(() => {
            if (useFade)
                rectTransform.localScale = Vector3.one;
            rectTransform.localPosition = orginPos;
            onComplete?.Invoke();
            _OnShowCompleted();
        });
    }
    public void Show(Action actionOnShowStart = null, Action actionOnShowCompleted = null, Action actionOnHideCompleted = null)
    {
        this.gameObject.SetActive(true);
        actionOnShowStart?.Invoke();
        this.actionOnHideCompleted = actionOnHideCompleted;
        PreAnimIn();
        AnimIn(actionOnShowCompleted);
    }
    public void Hide(Action onComplete = null)
    {
        rectTransform.DOKill();
        Vector2 tempPos = orginPos + offsetOut;
        Vector2 current = rectTransform.localPosition;
        float tempVal = 1;
        DOTween.To(() => tempVal, (x) =>
        {
            if (useFade)
                rectTransform.localScale = Vector3.one * x;
            rectTransform.localPosition = Vector2.Lerp(tempPos, current, x);
        }, 0, timeOut).SetDelay(delayOut).SetEase(easeOut).SetUpdate(UpdateType.Normal, isIndependentUpdate: true).SetTarget(rectTransform)
        .OnComplete(() => {
            if (useFade)
                rectTransform.localScale = Vector3.zero;
            rectTransform.localPosition = tempPos;
            onComplete?.Invoke();
            this.actionOnHideCompleted?.Invoke();
            _OnHideCompleted();
            this.gameObject.SetActive(false);
        });
    }
    public void SetHide()
    {
        this.gameObject.SetActive(false);
    }
    protected virtual void _OnShowCompleted()
    {
    }
    protected virtual void _OnHideCompleted()
    {
    }
}

//public enum UIAnimStatus
//{
//    IsHide,
//    IsShowing,
//    IsHiding,
//    IsShow
//}