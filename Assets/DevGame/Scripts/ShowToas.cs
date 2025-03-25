using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowToas : MonoBehaviour
{
    Vector3 pointBegin = Vector3.zero;
    private Tween tween;
    private Tween tween1;
    public RectTransform rectToas = null;

    // Start is called before the first frame update
    void Start()
    {
        pointBegin = rectToas.anchoredPosition;
    }

    public void RunActionToas()
    {
        if (tween1 != null || tween != null)
        {
            tween1.Kill();
            tween.Kill();
            tween = null;
            tween1 = null;
        }

        rectToas.gameObject.SetActive(true);
        rectToas.transform.localScale = Vector3.one * 0.75f;
        var pointSet = pointBegin + new Vector3(0, -150, 0);
        rectToas.anchoredPosition = pointSet;

        float time = 0.25f;

        tween = rectToas.transform.DOScale(1.0f, time).SetEase(Ease.InOutBack);
        tween1 = rectToas.DOAnchorPos(pointBegin, time).SetEase(Ease.InOutQuad).OnComplete(() => {
            StartCoroutine(DisableToas());
        });
    }

    IEnumerator DisableToas()
    {
        yield return new WaitForSeconds(0.25f);
        rectToas.gameObject.SetActive(false);
    }
}
