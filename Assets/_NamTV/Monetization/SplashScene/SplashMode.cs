using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SplashMode : SplashPopupBase
{
    [SerializeField] TextMeshProUGUI skipTitle;
    [SerializeField] List<ItemSelectSplash> itemList = new List<ItemSelectSplash>();
    int currentSelect;
    bool isSelected = false, canClose = false;
    
    protected override void Start()
    {
        base.Start();
        for (int i = 0; i < itemList.Count; i++)
        {
            itemList[i].Init(i);
            itemList[i].onSelected += OnItemClick;
            itemList[i]._OnActive(false);
        }
        canClose = false;
        isSelected = false;
        currentSelect = 100;
        timer = maxTimeIdle;
        closeBtn.interactable = false;
        skipTitle.gameObject.SetActive(true);
    }
    void OnItemClick(int _index)
    {
        timer = hideAfterSelected;
        isSelected = true;
        canClose = true;
        foreach (var item in itemList)
        {
            item._OnActive(item.INDEX == _index);
        }
        //Logic
        closeBtn.interactable = true;
        skipTitle.gameObject.SetActive(false);
        currentSave = _index;
        OnItemSelected();
    }
    private void Update()
    {
        if (!IsShow) return;
        if (isSelected)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                OnClose();
            }
            return;
        }
        timer -= Time.deltaTime;
        skipTitle.text = $"Auto close and show late in {Mathf.CeilToInt(timer)}s";
        if (timer <= 0)
        {
            isSelected = true;
            canClose = true;
            OnClose();
        }
    }
}
