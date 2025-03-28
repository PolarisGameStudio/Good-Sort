using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitNativeHelper : PersistentSingleton<InitNativeHelper>
{
    private void Start()
    {
        GameNativeHandle.Instance._InitOnHome();
    }
}
