using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class DataPlayer
{
    public bool isPlaySound = true;
    public bool isPlayMusic = true;
    public bool isVbration = true;

    #region GamePlay
    public int LevelID = 0;
    public int NumWinLevel = 0;

    public int TotalStar = 0;
    public int currentStarGame = 0;
    public int IndexStarLimit = 0;

    public int TotalCoin = 0;
    public int currentCoin = 0;

    #endregion

    public int BoosterKindBreakItem = 1;
    public int BoosterKindIncreaseTime = 1;
    public int BoosterKindX2_Star = 1;

    public int PowerBreakItem = 1;
    public int PowerFreeze = 1;
    public int PowerSwap = 1;
    public int PowerReplay = 1;

}
