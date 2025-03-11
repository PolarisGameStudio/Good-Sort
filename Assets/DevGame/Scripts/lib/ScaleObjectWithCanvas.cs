using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObjectWithCanvas : MonoBehaviour
{
    [SerializeField] bool isWidh = true;
    [SerializeField] Canvas canvas;
    [SerializeField] float xAdd = 0.0f;
    [SerializeField] bool isFlowWidh= false;
    void Start()
    {

        var siseCanvas = HelperManager.GetSizeOfCanvas(canvas);
        var rectTr = gameObject.GetComponent<RectTransform>();
        var size = rectTr.rect;

        if(isWidh)
        {
            if(isFlowWidh)
            {
                var scale = siseCanvas.x / (size.width + xAdd);
                rectTr.localScale = new Vector3(scale, scale, scale);
            }
            else
            {
                var sx = siseCanvas.x / (size.width + xAdd);
                var sy = siseCanvas.y / size.height;
                var s = Mathf.Min(sx, sy);
                rectTr.localScale = Vector3.one * s;

            }
        }
        else
        {
            var scale = siseCanvas.y / size.height;
            rectTr.localScale = new Vector3(scale, scale, scale);
        }
    }
}
