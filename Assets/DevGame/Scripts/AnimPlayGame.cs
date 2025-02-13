using Coffee.UIExtensions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPlayGame : Singleton<AnimPlayGame>
{
    public GameObject AnimStarCombo = null;
    public Transform ParentAnimStarCombo = null;
    public UIParticleAttractor uIParticleAttractorStar = null;

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
        yield return new WaitForSeconds(0.2f);
        paAnimSucess.transform.position = Vector3.one * 1000;
        paAnimSucess.transform.parent = null;
    }

    public void PlayAnimStarCombo(int star, Vector3 pos)
    {
        var anim = Instantiate(AnimStarCombo, ParentAnimStarCombo);
        anim.transform.position = pos;
        var uiPartical = anim.GetComponent<UIParticle>();
        var partiCal = uiPartical.particles[0];
        uIParticleAttractorStar.AddParticleSystem(partiCal);
        uiPartical.Play();
        partiCal.Play();
        partiCal.Emit(6);
        var time = partiCal.main.duration;
        uiPartical.StartCoroutine(DestroyObject(time, anim));
    }    

    IEnumerator DestroyObject(float time, GameObject obj)
    {
        yield return new WaitForSeconds(5);
        Destroy(obj);
    }    
}
