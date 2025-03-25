using Coffee.UIExtensions;
using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


[Serializable]
public struct DataReciverItem
{
    public ResourceType resourceType;
    public List<Transform> listObj;
    public Transform trParent;
    public UIParticle fx;
    public Transform objStar;
}

public class UIReciverItem : MonoBehaviour
{
    public List<DataReciverItem> dataReciverItems;
    [SerializeField] TextMeshProUGUI txtStar;

    [SerializeField] TextMeshProUGUI txtToitalStar;

    [SerializeField] TextMeshProUGUI txtStarAdd;

    [SerializeField] TextMeshProUGUI txtgold;

    int _Index = 0;
    [SerializeField] Ease ease; 

    // Start is called before the first frame update
    void Start()
    {
    }

    public void RunAnim()
    {

        Audio.Play(ScStatic.SFX_UI_ResourceAppear);

        _Index = 0;
        foreach (var item in dataReciverItems)
        {
            if (item.resourceType == ResourceType.Star && HelperManager.DataPlayer.currentStarGame > 0)
            {
                _Index += item.listObj.Count;
            }

            if (item.resourceType == ResourceType.Gold && HelperManager.DataPlayer.currentCoin > 0)
            {
                _Index += item.listObj.Count;
            }

        }

        int index1 = 0;
        int ind = 0;
        foreach (var item in dataReciverItems)
        {
            var dic = item.trParent;
            if (item.resourceType == ResourceType.Star)
            {
                if(HelperManager.DataPlayer.currentStarGame > 0)
                {
                    txtStar.text = HelperManager.DataPlayer.currentStarGame.ToString();
                    if (item.objStar)
                    {
                        item.objStar.gameObject.SetActive(true);
                        item.objStar.DOMove(dic.transform.position, 0.85f).SetEase(ease).SetDelay(0.35f).OnComplete(() => {
                            item.objStar.gameObject.SetActive(false);
                            HelperManager.OnAddStarGame(HelperManager.DataPlayer.currentStarGame);
                            HelperManager.DataPlayer.currentStarGame = 0;
                            txtToitalStar.text = HelperManager.DataPlayer.TotalStar.ToString();
                        });
                    }
                }
                else
                {
                    continue;
                }
                
            }

            if (item.resourceType == ResourceType.Gold && HelperManager.DataPlayer.currentCoin <= 0)
            {
                continue;
            }

            float time = 0.2f + index1 * 0.2f;
            index1++;
            int index = 1;

            foreach(var obMove in item.listObj)
            {
                var timeMove = UnityEngine.Random.Range(0.1f, 0.2f);
                var pointDown = obMove.transform.position + new Vector3(UnityEngine.Random.Range(-5.5f, -12.5f), UnityEngine.Random.Range(-5.5f, -13.5f));

                obMove.DOMove(pointDown, 0.15f).SetEase(ease).OnComplete(() =>
                {
                    obMove.DOMove(dic.transform.position, 0.3f).SetEase(ease).OnComplete(() => {
                        ind++;
                        if(ind >= _Index)
                        {
                            StartCoroutine(Disable());
                        }

                        if(item.resourceType == ResourceType.Gold)
                        {
                            Audio.Play(ScStatic.SFX_UI_RecivedGold);
                        }

                        if (item.resourceType == ResourceType.Gold)
                        {
                            Audio.Play(ScStatic.SFX_UI_RecivedStar);
                        }


                        item.fx.Play();
                        obMove.gameObject.SetActive(false);
                    }).SetDelay(UnityEngine.Random.Range(0.1f, 0.2f));
                }).SetDelay(0.15f * index).OnStart(() => {
                    obMove.gameObject.SetActive(true);
                });
                index++;
            }
        }
    }

    IEnumerator Disable()
    {
        yield return new WaitForSeconds(0.25f);
        gameObject.SetActive(false);
        HelperManager.DataPlayer.TotalCoin += HelperManager.DataPlayer.currentCoin;
        txtgold.text = HelperManager.DataPlayer.TotalCoin.ToString();
        txtToitalStar.text = HelperManager.DataPlayer.TotalStar.ToString();
        HelperManager.DataPlayer.currentStarGame = 0;
        HelperManager.DataPlayer.currentCoin = 0;
    }

    void Update()
    {
        
    }
}
