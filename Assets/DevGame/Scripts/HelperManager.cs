using Cysharp.Threading.Tasks;
using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public static class HelperManager
{

    private static DataPlayer _dataPlayer = null;

    public static DataPlayer DataPlayer
    {
        get
        {
            if (_dataPlayer == null)
            {
                StorageHandler storageHandler = new StorageHandler();

                if (storageHandler.IsExitKey(ScStatic.PLAYERDATA))
                {
                    _dataPlayer = storageHandler.LoadData<DataPlayer>(ScStatic.PLAYERDATA);
                }

                if (_dataPlayer == null)
                {
                    _dataPlayer = new DataPlayer();

                    Save();
                }
            }

            return _dataPlayer;
        }
        set
        {
            _dataPlayer = value;
        }
    }

    public static void Save()
    {
        var storage = new StorageHandler();
        storage.SaveData<DataPlayer>(ScStatic.PLAYERDATA, DataPlayer);
    }


    public static Vector2 GetSizeOfCanvas(Canvas canvas)
    {
        if(canvas == null)
        {
            if(ScStatic.SizeCanvas.x == 0)
            {
                return new Vector2(Screen.width, Screen.height);
            }

            return ScStatic.SizeCanvas;
        }
        RectTransform canvasRect = canvas.GetComponent<RectTransform>();
        float width = canvasRect.rect.width;
        float height = canvasRect.rect.height;
        return new Vector2(width, height);
    }


    public static Vector2 ConvertWorldToCanvasPoint(Canvas canvas, Vector3 worldPosition)
    {
        Vector2 screenPoint = Camera.main.WorldToScreenPoint(worldPosition);
        Vector2 canvasPoint;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.GetComponent<RectTransform>(), screenPoint, Camera.main, out canvasPoint);

        return canvasPoint;
    }

    public static void OnPlayGame()
    {
        OnLoadScene(ScStatic.GAME_SCENE);
    }

    public static void OnBackHomeScene()
    {
        /*if (callbackLoadScene != null)
        {
            callbackLoadScene.allowSceneActivation = true;
            callbackLoadScene.allowSceneActivation = false;
            callbackLoadScene = null;
        }*/

        if (DataPlayer.LevelID < 2)
        {
            OnLoadGameScene();
            ShowGameScene();
            return;
        }

        callbackLoadScene = null;
        SceneManager.LoadScene(ScStatic.HOME_SCENE);
    }

    public static Vector2 GetSizeCameraInWord()
    {
        Camera mainCamera = Camera.main;
        var height = mainCamera.orthographicSize * 2;
        var width = (float)Screen.width / (float)Screen.height * height;
        return new Vector2(width, height);
    }

    #region LOAD_SCENE
    public static async UniTask OnLoadScene(string scene, LoadSceneMode mode = LoadSceneMode.Single, Action<AsyncOperation> callback = null)
    {
        await PreloadSceneAsync(scene, mode, callback);
       // UnityEngine.SceneManagement.SceneManager.LoadScene(scene, mode);
    }

    public static bool IsLoadGameSceneSucess = false;
    public static AsyncOperation callbackLoadScene = null;

    public static async UniTask OnLoadGameScene()
    {
        if(callbackLoadScene != null)
        {
            return;
        }    
        
        IsLoadGameSceneSucess = false;
        callbackLoadScene = null;

        await UniTask.Yield();
        await UniTask.Yield();
        await UniTask.Yield();

        OnLoadScene(ScStatic.GAME_SCENE, LoadSceneMode.Single, scene => {
            callbackLoadScene = scene;
            IsLoadGameSceneSucess = true;
        });
    }

    public static async void ShowGameScene()
    {
        while (true)
        {
            if(IsLoadGameSceneSucess)
            {
                break;
            }
            await UniTask.Yield();
        }

        callbackLoadScene.allowSceneActivation = true;
        callbackLoadScene = null;
    }


    public static async UniTask PreloadSceneAsync(string sceneName, LoadSceneMode mode, Action<AsyncOperation> callback = null)
    {
        var asyncOperation = SceneManager.LoadSceneAsync(sceneName, mode);
        asyncOperation.allowSceneActivation = false;

        while (!asyncOperation.isDone)
        {
            
            if (asyncOperation.progress >= 0.8999f)
            {
                break;
            }

            await UniTask.Yield(); 
        }

        if(callback != null)
        {
            callback?.Invoke(asyncOperation);
        }
        else
        {
            asyncOperation.allowSceneActivation = true;
        }
    }

    #endregion

    public static void Shuffle<T>(List<T> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int randomIndex = UnityEngine.Random.Range(0, i + 1);
            T temp = list[i];
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }

    public static void OnAddStarGame(int starAdd)
    {
        DataPlayer.TotalStar += starAdd;
    }

    public static int GetNumPower(PowerupKind kind)
    {
        switch(kind)
        {
            case PowerupKind.BreakItem:
                {
                    return DataPlayer.PowerBreakItem;
                }
            case PowerupKind.Freeze:
                {
                    return DataPlayer.PowerFreeze;
                }
            case PowerupKind.Replace:
                {
                    return DataPlayer.PowerReplay;
                }
            case PowerupKind.Swap:
                {
                    return DataPlayer.PowerSwap;
                }
        }

        return 0;
    }

    public static void OnAddTotalCoin(int coin)
    {
        DataPlayer.TotalCoin += coin;
        if (DataPlayer.TotalCoin <= 0)
        {
            DataPlayer.TotalCoin = 0;
        }

        var kk = GameObject.FindObjectsOfType<UIResource>().ToList();

        if (kk.Count > 0)
        {
            foreach(var it in kk)
            {
                it.UpdateUi();
            }
        }
    }

}
