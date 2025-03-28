using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWaitScreen : PersistentSingleton<UIWaitScreen>
{
    bool isActive = false;
    Coroutine enumerator = null;
    public void _waitForLoading(string mesage,float _timeWait = 3,Action _onStart = null,Action _onComplete = null)
    {
        isActive = true;
        AdsLoading.ShowLoading(mesage, _timeWait,showAdsBrake:true);
        UnityMainThreadDispatcher.Enqueue(() => _onStart?.Invoke());
        if(enumerator != null)
            StopCoroutine(enumerator);
        enumerator = StartCoroutine(_waitCoroutine(_timeWait, _onComplete));
    }
    IEnumerator _waitCoroutine(float _timeWait = 2, Action _onComplete = null)
    {
        yield return new WaitForSeconds(_timeWait);
        AdsLoading.HideLoading();
        if (isActive)
            UnityMainThreadDispatcher.Enqueue(() => _onComplete?.Invoke());
        isActive = false;
    }
    public void _forceHide()
    {
        if (enumerator != null)
            StopCoroutine(enumerator);
        isActive = false;
        AdsLoading.HideLoading();
    }
    private void OnDisable()
    {
        isActive = false;
        if (enumerator != null)
            StopCoroutine(enumerator);
    }
}
