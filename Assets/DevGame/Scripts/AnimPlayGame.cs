using Coffee.UIExtensions;
using Spine.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
struct NameAndAudioComboGame
{
    public string nameAudio;
    public string nameCombo;
}

public class AnimPlayGame : Singleton<AnimPlayGame>
{
    [Header("Star Game")]
    public GameObject AnimStarCombo = null;
    public Transform ParentAnimStarCombo = null;
    public UIParticleAttractor uIParticleAttractorStar = null;

    [Header("Anim Meger Sucess")]
    public GameObject AnimSucess = null;
    private ParticleSystem paAnimSucess = null;

    [Header("Anim Combo")]
    [SerializeField] private GameObject SpineCombo = null;
    [SerializeField] private List<NameAndAudioComboGame> NameAudioCombos = null;

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
        partiCal.Emit(star - 1);
        var time = partiCal.main.duration;
        uiPartical.StartCoroutine(DestroyObject(time, anim));
    }    

    IEnumerator DestroyObject(float time, GameObject obj)
    {
        yield return new WaitForSeconds(5);
        Destroy(obj);
    }    

    public void OnPlayAnimCombo(Vector3 pointCombo, int numCombo, Transform parent)
    {
        if (numCombo >= NameAudioCombos.Count)
        {
            numCombo = NameAudioCombos.Count - 1;
        }

        var daCombo = NameAudioCombos[numCombo];
        var anim = Instantiate(SpineCombo, parent);
        var sp = anim.GetComponent<SkeletonAnimation>();
        sp.Skeleton.SetSkin(daCombo.nameCombo);
        sp.StartCoroutine(DestroyObject(5, anim.gameObject));

    }
}
