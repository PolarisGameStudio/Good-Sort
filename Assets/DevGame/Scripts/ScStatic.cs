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

    public static int currentStarGame = 0;


    public static Vector2 SizeCanvas = Vector2.zero;
    public static List<BoosterKind> ListBoosterStart = new();

    public static Vector3 PointItemLeft = new Vector3(-1.09f, 0, 0);
    public static Vector3 PointItemMid = new Vector3(0, 0, 0);
    public static Vector3 PointItemRight = new Vector3(1.09f, 0, 0);
    public static Vector3 PointItemCell = new Vector3(0, 0.155f, 0);

}
