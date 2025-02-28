using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BgGameCanvas : MonoBehaviour
{
    [SerializeField] Canvas _canvas;

    [SerializeField] bool IsUseMaxSize = true;

    void Start()
    {
        if (_canvas == null)
        {
            _canvas = GameObject.FindAnyObjectByType<Canvas>();
        }
        var sizeCanvas = HelperManager.GetSizeOfCanvas(_canvas);

        var rectTransfrom = gameObject.GetComponent<RectTransform>();

        var sizeBg = rectTransfrom.rect;

        var scaleX = sizeCanvas.x / sizeBg.width;
        var scaleY = sizeCanvas.y / sizeBg.height;

        var scale = IsUseMaxSize ? Mathf.Max(scaleX, scaleY) : Mathf.Min(scaleX, scaleY);

        Debug.Log("cmmm" + scale + "/" + sizeCanvas + "/" + sizeBg);

        if(!IsUseMaxSize && (scaleX < 1.0f || scaleY < 1.0f) || IsUseMaxSize)
        {
            rectTransfrom.localScale = new Vector3(scale, scale, scale);
        }
    }

  
}
