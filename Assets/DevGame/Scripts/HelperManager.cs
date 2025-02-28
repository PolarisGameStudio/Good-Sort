using Cysharp.Threading.Tasks;
using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
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

    public static void OnBackHomeScene()
    {

        OnLoadScene(ScStatic.GAME_SCENE);
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

}
