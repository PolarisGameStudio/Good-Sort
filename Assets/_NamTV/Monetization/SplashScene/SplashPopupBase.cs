using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplashPopupBase : MonoBehaviour
{
    [SerializeField] SplashPopupType saveKey = SplashPopupType.SelectMode;
    [SerializeField] protected Button closeBtn;
    [SerializeField] CanvasGroup canvasGroup;
    [SerializeField] protected float maxTimeIdle = 10f;
    [SerializeField] protected float hideAfterSelected = 5f;
    protected int currentSave = -1;
    protected bool IsShow = false;
    protected float timer = 0;
    public bool ForceUse => currentSave == -1;
    
    protected virtual void Start()
    {
        if (closeBtn)
        {
            closeBtn.onClick.RemoveAllListeners();
            closeBtn.onClick.AddListener(OnClose);
        }
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public virtual bool _OnInit()
    {
        currentSave = SplashHelper.GetSaveData(saveKey);
        IsShow = false;
        return ForceUse;
    }
    public virtual void OnItemSelected()
    {
        GameNativeHandle.Instance.RequestNativeSplash();
    }
    public void _OnShow()
    {
        IsShow = true;
        gameObject.SetActive(true);
        canvasGroup.DOKill();
        canvasGroup.DOFade(1, 1);
    }
    protected void OnDisable()
    {
        _OnHide();
    }
    public void _OnHide()
    {
        
        SaveData();
    }
    protected void SaveData()
    {
        SplashHelper.SaveData(saveKey, currentSave);
    }
    protected void OnClose()
    {
        IsShow = false;
        _OnClose?.Invoke();
    }
    public Action _OnClose;
}
