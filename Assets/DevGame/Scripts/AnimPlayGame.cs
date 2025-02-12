using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.ShaderData;

public class AnimPlayGame : Singleton<AnimPlayGame>
{
    public GameObject AnimSucess = null;

    private ParticleSystem paAnimSucess = null;

    void Start()
    {
		var animS = Instantiate(AnimSucess, null);
        paAnimSucess = animS.GetComponent<ParticleSystem>();
        paAnimSucess.transform.position = Vector3.one * 1000;
    }

    public void OnPlayAnimMegerSucess(Vector3 posss, Transform parent)
    {
        paAnimSucess.transform.parent = parent;
        paAnimSucess.transform.localPosition = posss;
        paAnimSucess.Play();
        paAnimSucess.transform.localScale = Vector3.one * 1;
        StartCoroutine(StartPlayAnim());

    }

    IEnumerator StartPlayAnim()
    {
        yield return new WaitForSeconds(paAnimSucess.totalTime);
        paAnimSucess.transform.position = Vector3.one * 1000;
        paAnimSucess.transform.parent = null;
    }
}
