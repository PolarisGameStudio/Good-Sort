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
    public int TotalStar = 0;
    public int NumWinLevel = 0;
    #endregion

    public int BoosterKindBreakItem = 3;
    public int BoosterKindIncreaseTime = 3;
    public int BoosterKindX2_Star = 3;

}
