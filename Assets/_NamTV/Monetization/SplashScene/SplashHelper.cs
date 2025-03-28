using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SplashHelper
{
    public static int GetSaveData(SplashPopupType popupType)
    {
        return PlayerPrefs.GetInt(popupType.ToString(), -1);
    }
    public static void SaveData(SplashPopupType popupType,int _saveData)
    {
        PlayerPrefs.SetInt(popupType.ToString(), _saveData);
    }
    public static bool _CanUseSplashPopup()
    {
        foreach (SplashPopupType popupType in Enum.GetValues(typeof(SplashPopupType)))
        {
            if (GetSaveData(popupType) == -1)
            {
                return true;
            }
        }
        return false;
    }
}
[Serializable]
public enum SplashPopupType
{
    SelectMode = 0,
    SelectAge = 1,
}