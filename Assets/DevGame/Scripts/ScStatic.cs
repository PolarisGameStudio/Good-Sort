using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScStatic
{
    public static string PLAYERDATA = "Good_sort_data";

    public static string GAME_SCENE = "GameScene";
    public static string HOME_SCENE = "Menu";
    public static string SPLASH_SCENE = "SplashScene";
    public static string FIND_THE_DIFFERENCE_GAME_SCENE = "FindTheDifferenceGame";
    public static string MASTER_CHEF_GAME = "MasterChefGame";
    public static string MUSIC_BEAT = "AudioGame";


    public static string MUSIC_HOME = "Home";
    public static string MUSIC_GAME = "Game";

    #region SFX

    public static List<string> SFX_COMBOS = new List<string>()
    {
        "SFX_Ingame_MatchGoods",
        "SFX_MatchCombo2_X2",
        "SFX_MatchCombo2_X3",
        "SFX_MatchCombo2_X4",
        "SFX_MatchCombo2_X5",
        "SFX_MatchCombo2_X6",
        "SFX_MatchCombo2_X7",
        "SFX_MatchCombo2_X8",
        "SFX_MatchCombo2_X9",
        "SFX_MatchCombo2_X10",
        "SFX_MatchCombo2_X11",
    };

    public static string SFX_LostCombo = "SFX_LostCombo";
    public static string SFX_Ingame_PutDownGood = "SFX_Ingame_PutDownGood";
    public static string SFX_Ingame_CellDrop = "SFX_Ingame_CellDrop";
    public static string SFX_Ingame_PowerUp_TimeFreeze = "SFX_Ingame_PowerUp_TimeFreeze";
    public static string SFX_Ingame_UsePowerUp = "SFX_Ingame_UsePowerUp";
    public static string SFX_Ingame_PowerUp_Hammer = "SFX_Ingame_PowerUp_Hammer";
    public static string SFX_Ingame_PowerUp_MagicWard = "SFX_Ingame_PowerUp_MagicWard";
    public static string SFX_Ingame_PowerUp_Swap = "SFX_Ingame_PowerUp_Swap";
    public static string SFX_Ingame_Warning = "SFX_Ingame_Warning";
    public static string SFX_Ingame_PowerUp_TimeBonus = "SFX_Ingame_PowerUp_TimeBonus";
    public static string SFX_Ingame_Booster_2xStar = "SFX_Ingame_Booster_2xStar";
    public static string SFX_Ingame_Booster_Hammer = "SFX_Ingame_Booster_Hammer";
    public static string SFX_Ingame_Confetti = "SFX_Ingame_Confetti";
    public static string SFX_Ingame_FoodFight_ConfettiWin = "SFX_Ingame_FoodFight_ConfettiWin";
    public static string SFX_Ingame_FoodFight_RewardAppear = "SFX_Ingame_FoodFight_RewardAppear";
    public static string SFX_Ingame_CellLock_Unlock = "SFX_Ingame_CellLock_Unlock";
    public static string SFX_Ingame_FoodFight_ConfettiLose = "SFX_Ingame_FoodFight_ConfettiLose";
    public static string SFX_Ingame_StartWave = "SFX_Ingame_StartWave";
    public static string SFX_UI_Chest_Open = "SFX_UI_Chest_Open";
    public static string SFX_UI_Button = "SFX_UI_Button";
    public static string SFX_UI_ResourceAppear = "SFX_UI_ResourceAppear";
    public static string SFX_UI_RecivedGold = "SFX_UI_RecivedGold";
    public static string SFX_UI_RecivedStar = "SFX_UI_RecivedStar";

    #endregion

    public static Vector2 SizeCanvas = Vector2.zero;
    public static List<BoosterKind> ListBoosterStart = new();

    public static Vector3 PointItemLeft = new Vector3(-1.09f, 0, 0);
    public static Vector3 PointItemMid = new Vector3(0, 0, 0);
    public static Vector3 PointItemRight = new Vector3(1.09f, 0, 0);
    public static Vector3 PointItemCell = new Vector3(0, 0.155f, 0);

}
