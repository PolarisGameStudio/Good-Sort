using DG.Tweening;
using UnityEngine;
using UnityEngine.UIElements;

public class BounceScale : MonoBehaviour
{
    public float scaleAmount = 0.7f;  
    public float duration = 1.0f;     

    void Start()
    {
        var ScaleAdd = new Vector3(0.1f, -0.05f);
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOScale(Vector3.one + ScaleAdd, duration).SetEase(Ease.InOutSine)) 
                .Append(transform.DOScale(Vector3.one - ScaleAdd, duration).SetEase(Ease.InOutSine))

        .SetLoops(-1, LoopType.Yoyo);

    }

}
