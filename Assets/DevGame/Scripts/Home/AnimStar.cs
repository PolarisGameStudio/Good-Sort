using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimStar : MonoBehaviour
{

    [SerializeField] List<Sprite> sprites;
    [SerializeField] Image image;
    [SerializeField] float delayTime = 0.1f;

    [SerializeField] bool isDelay = true;
    [SerializeField] CanvasGroup canvasGroup = null;


    int index = 0;

    void Start()
    {
        this.StartCoroutine(StarAnim());
       /* float scale = UnityEngine.Random.Range(1.0f, 2.5f);
        gameObject.GetComponent<RectTransform>().localScale = Vector3.one * scale;*/
    }

    IEnumerator StarAnim()
    {
        yield return new WaitForSecondsRealtime(isDelay ? UnityEngine.Random.Range(0.0f, 1.5f) : 0) ;
        this.StartCoroutine(PlayAnim());
    }

    IEnumerator PlayAnim()
    {
        float indexCanvas = 1.0f;

        while (indexCanvas >= 0.5)
        {
            indexCanvas -= delayTime* delayTime;
            canvasGroup.alpha = indexCanvas;
            yield return null;
            yield return new WaitForEndOfFrame();
        }

        indexCanvas = 0.5f;


        yield return new WaitForSecondsRealtime(delayTime);
        yield return new WaitForEndOfFrame();

        if (index >= sprites.Count)
        {
            index = 0;
        }
        image.sprite = sprites[index];
        image.SetNativeSize();
        index++;

        while (indexCanvas <= 1.0)
        {
            indexCanvas += delayTime * delayTime;
            canvasGroup.alpha = indexCanvas;
            yield return null;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForSeconds(0.25f);

        this.StartCoroutine(PlayAnim());
    }
   
}
