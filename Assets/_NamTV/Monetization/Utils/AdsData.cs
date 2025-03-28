using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class AdsSettingKeyID
{
    [SerializeField, Space] public List<string> key_android;
    [SerializeField, Space] public List<string> key_ios;
}
public class MainThreadEvent
{
    private SimpleCallback callback;
    public SimpleCallback Callback => callback;

    public MainThreadEvent(SimpleCallback callback)
    {
        this.callback = callback;
    }
}
public delegate void SimpleCallback();