using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SplashAge : SplashPopupBase
{
    [SerializeField] Button previousBtn, nextBtn,submitBtn;
    [SerializeField] TextMeshProUGUI ageTxt;
    [SerializeField] int minAge = 5;
    [SerializeField] int maxAge = 200;
    [SerializeField] int currentAge = 7;
    
    bool canSubmit = false;
    protected override void Start()
    {
        base.Start();
        previousBtn.onClick.RemoveAllListeners();
        previousBtn.onClick.AddListener(OnPrevious);
        nextBtn.onClick.RemoveAllListeners();
        nextBtn.onClick.AddListener(OnNext);
        submitBtn.onClick.RemoveAllListeners();
        submitBtn.onClick.AddListener(OnSubmit);
        UpdateAge(true);
    }
    private void OnSubmit()
    {
        if (!canSubmit) return;
        currentSave = currentAge;
        OnClose();
    }

    private void OnNext()
    {
        timer = hideAfterSelected;
        canSubmit = true;
        currentAge = Mathf.Clamp(currentAge + 1, minAge, maxAge);
        UpdateAge();
        OnItemSelected();
    }

    private void OnPrevious()
    {
        timer = hideAfterSelected;
        canSubmit = true;
        currentAge = Mathf.Clamp(currentAge - 1, minAge, maxAge);
        UpdateAge();
        OnItemSelected();
    }
    private void UpdateAge(bool _init = false)
    {
        ageTxt.text = _init ? "--" : currentAge.ToString();
        previousBtn.interactable = currentAge >= minAge;
        nextBtn.interactable = currentAge <= maxAge;
    }
    private void Update()
    {
        if (!IsShow) return;
        if (canSubmit)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                OnSubmit();
            }
            return;
        }
        timer += Time.deltaTime;
        if(timer >= maxTimeIdle)
        {
            OnClose();
        }
    }
}
