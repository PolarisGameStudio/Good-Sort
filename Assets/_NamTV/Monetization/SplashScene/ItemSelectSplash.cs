using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSelectSplash : MonoBehaviour
{
    int m_index = 0;
    [SerializeField] Button m_button;
    [SerializeField] GameObject selectObject;
    public Action<int> onSelected;
    private void Start()
    {
        m_button = GetComponent<Button>();
        m_button.onClick.RemoveAllListeners();
        m_button.onClick.AddListener(OnSelect);
    }
    public void Init(int _index) => m_index = _index;
    public int INDEX => m_index;
    void OnSelect()
    {
        onSelected?.Invoke(m_index);
    }
    public void _OnActive(bool active)
    {
        selectObject.SetActive(active);
    }
}
