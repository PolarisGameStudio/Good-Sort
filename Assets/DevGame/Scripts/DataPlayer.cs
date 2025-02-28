using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class DataPlayer
{
    public int NumLevel = 0;
    public bool isPlaySound = true;
    public bool isPlayMusic = true;
    public bool isVbration = true;

    public int NumTotalSpin = 0;
    public int TotalCoin = 0;
    public int CurrentId = 0;
    public int currentCandyId = 0;
    public int currentFindDifferencesID = 0;
    
    public List<int> listNormalModeAds = new List<int>() {2, 7, 8, 9, 12, 14, 15};
    public List<int> listNoelModeAds = new List<int>() {3, 6, 8, 9, 11, 14, 16};
    public List<int> listMixModeAds = new List<int>() {1, 4, 6, 7, 9, 12, 14, 15};
    public int levelMasterChef = 0;
    public int highScore = 0;

    public bool isStartFindPoints = false;
    public int NumLevelGameAnimal = 0;
    public List<int> listPointSelected = new List<int>();

    public int LevelIDScreamChicken = 0;
    public int currentModeIndex = 0;


}
