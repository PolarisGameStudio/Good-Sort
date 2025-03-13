using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Spine;
using Spine.Unity;
using UnityEngine;

public class PowerupSwap : MonoBehaviour
{

	[SerializeField]
	private SkeletonAnimation _anim;

	[SerializeField]
	private Transform _fx;
    private Transform _fxClone;

	[SerializeField]
	private ParticleSystem _fxBurt;
    private ParticleSystem _fxBurtClone;


    List<DataItemSkillSwap> dataItemSkillSwaps = new();

    Action callbackMoveEnd = null;

    public void OnSkillSwap(List<Cell> listCellAllGame, Vector3 pointMid, Action callbackSucess, bool isGameOver)
	{
        dataItemSkillSwaps.Clear();
        _anim.gameObject.SetActive(true);
        StartCoroutine(StartAnim());
        var Cells = listCellAllGame.Where(x => x != null && !x.IsLock).ToList();

        HelperManager.Shuffle(Cells);

        var celsLayerCount = Cells.Where(x => x.CellType == CellType.CellLayerCount).ToList();
        var celsSingle = Cells.Where(x => x.CellType == CellType.CellSingle).ToList();

        List<Item> listItems = new();

        foreach (var cel in Cells)
        {
            cel.CheckSetItemForSkill();
            var item = cel.GetListItemForSkillSwap();
            if (item != null && item.Count > 0)
            {
                listItems.AddRange(item);
            }
        }

        listItems = listItems.Where(x=>x != null).ToList();

        listItems.Sort((a, b) => a.ItemType - b.ItemType);

        if(isGameOver)
        {
            var groupedPositions = listItems.GroupBy(pos => pos.ItemType).ToDictionary(group => group.Key, group => group.ToList());

            if (groupedPositions != null && groupedPositions.Count > 0)
            {
                var gr1 = groupedPositions.Where(x => x.Value.Count > 2).ToList();

                List<Item> itemRemove = new();

                foreach (var it in gr1)
                {
                    var pd = it.Value.Count % 3;
                    if (pd == 0)
                    {
                        continue;
                    }

                    for (int i = 0; i < pd; i++)
                    {
                        it.Value.RemoveAt(0);
                    }

                }

                foreach (var it in gr1)
                {
                    itemRemove.AddRange(it.Value);
                    if (itemRemove.Count >= 3)
                    {
                        while (itemRemove.Count > 3)
                        {
                            itemRemove.RemoveAt(0);
                        }
                        break;
                    }    
                }

                foreach (var item in itemRemove)
                {
                    item.transform.parent = null;
                    item.itemContainer.RemoveIndexItemInLayerItem(item);
                    listItems.Remove(item);
                    Destroy(item.gameObject);
;                }
            }
        }


        int num11 = listItems.Count;
        var numItemww = 0;

        //LayerCount
        Dictionary<Cell, List<List<Item>>> dictDataCell = new();

        foreach (var item in celsLayerCount)
        {
            List<List<Item>> listItemAdd = new();
            List<Item> listIt = new();
            var itemCell = listItems[0];
            listItems.RemoveAt(0);
            listIt.Add(itemCell);
            listItemAdd.Add(listIt);
            dictDataCell.Add(item, listItemAdd);
        }


        foreach (var item in celsSingle)
        {
            List<List<Item>> listItemAdd = new();
            if (listItems.Count == 0)
            {
                break;
            }

            List<Item> listItLayer1 = GetListItemByCount(1, listItems);
            List<Item> listItLayer2 = GetListItemByCount(1, listItems);

            if (listItLayer1 != null && listItLayer1.Count > 0)
            {
                listItemAdd.Add(listItLayer1);
            }

            if (listItLayer2 != null && listItLayer2.Count > 0)
            {
                listItemAdd.Add(listItLayer2);
            }

            if (listItemAdd.Count > 0)
            {
                dictDataCell.Add(item, listItemAdd);
            }

        }

        foreach (var it in Cells)
        {
            if (dictDataCell.ContainsKey(it))
            {
                continue;
            }
            if (listItems.Count == 0)
            {
                break;
            }
            List<List<Item>> listItemAdd = new();
            var listItemNew = GetListItemByCount(2, listItems);
            if (listItemNew.Count > 0)
            {
                listItemAdd.Add(listItemNew);
                dictDataCell.Add(it, listItemAdd);
            }
        }

        if (listItems.Count > 0)
        {
            foreach (var it in dictDataCell)
            {
                if (it.Key.CellType == CellType.CellLayerCount || it.Key.CellType == CellType.CellSingle)
                {
                    continue;
                }
                if (listItems.Count == 0)
                {
                    break;
                }
                var listItemNew = GetListItemByCount(2, listItems);

                if (listItemNew.Count > 0)
                {
                    it.Value.Add(listItemNew);
                }
            }
        }

        foreach (var it in dictDataCell)
        {
            foreach (var ic in it.Value)
            {
                numItemww += ic.Count;
            }
        }

        if (listItems.Count > 0)
        {
            foreach (var it in dictDataCell)
            {
                if (it.Key.CellType == CellType.CellLayerCount || it.Key.CellType == CellType.CellSingle)
                {
                    continue;
                }
                if (listItems.Count == 0)
                {
                    break;
                }
                var listItemNew = GetListItemByCount(1, listItems);

                if (listItemNew.Count > 0)
                {
                    it.Value[0].Add(listItemNew[0]);
                }
            }

        }

        if (listItems.Count > 0)
        {
            foreach (var it in dictDataCell)
            {
                if (it.Key.CellType == CellType.CellLayerCount || it.Key.CellType == CellType.CellSingle)
                {
                    continue;
                }
                if (listItems.Count == 0)
                {
                    break;
                }
                var listItemNew = GetListItemByCount(1, listItems);

                if (listItemNew.Count > 0)
                {
                    it.Value[1].Add(listItemNew[0]);
                }
            }
        }

        var newdict = dictDataCell.Where(it => it.Key.CellType != CellType.CellLayerCount && it.Key.CellType != CellType.CellSingle).ToList();


        int index = 0;

        foreach (var dic in newdict)
        {
            if (dic.Value[0].Count == 3)
            {
                index++;
            }
        }

        var numCount = UnityEngine.Random.Range(3, 4);

        if (newdict.Count - index <= numCount)
        {
            List<Item> listItemChange = new();
            int countCheck = 3;

            while (true)
            {
                bool iscontinue = false;
                foreach (var dic in newdict)
                {
                    if (dic.Value[0].Count == countCheck)
                    {
                        var it = dic.Value[0][0];
                        dic.Value[0].Remove(it);
                        listItemChange.Add(it);
                        if (listItemChange.Count > numCount)
                        {
                            break;
                        }

                        iscontinue = true;
                    }
                }

                if (listItemChange.Count > numCount || !iscontinue)
                {
                    break;
                }

                countCheck = 2;
            }

            if (listItemChange.Count > 0)
            {
                foreach (var it in listItemChange)
                {
                    foreach (var dic in newdict)
                    {
                        if (dic.Value.Count < 2)
                        {
                            break;
                        }
                        if (dic.Value[1].Count < 3)
                        {
                            dic.Value[1].Add(it);
                            break;
                        }
                    }
                }
            }
        }
        else
        {
            var numItem = newdict.Count - index - numCount;
            List<Item> listItemChange = new();
            foreach (var it in newdict)
            {
                if (it.Value.Count < 2)
                {
                    break;
                }
                if (it.Value[1].Count > 1)
                {
                    var item = it.Value[1][0];
                    it.Value[1].Remove(item);
                    listItemChange.Add(item);
                    if (listItemChange.Count == numItem)
                    {
                        break;
                    }
                }
            }

            foreach (var item in listItemChange)
            {
                foreach (var it in newdict)
                {
                    if (it.Value[0].Count < 3)
                    {
                        it.Value[0].Add(item);
                        break;
                    }
                }
            }

        }

        numItemww = 0;

        foreach (var it in dictDataCell)
        {
            foreach (var ic in it.Value)
            {
                numItemww += ic.Count;
            }
        }


        foreach (var it in dictDataCell)
        {
            it.Key.CreateLayerItemSkillSwap(it.Value, ref dataItemSkillSwaps);
        }

        int count = dataItemSkillSwaps.Count;
        int indexCount = 0;

        callbackMoveEnd = () => {
            indexCount++;

            if (indexCount == count)
            {
                callbackSucess?.Invoke();
            }
        };

        Action callbackMoveMid = () => {
            indexCount++;
            if (indexCount == count)
            {
                indexCount = 0;
            }
        };

        foreach (var it in dataItemSkillSwaps)
        {
            if(it.item == null)
            {
                continue;
            }    
            it.item.OnStartMoveSkillSwap(pointMid, callbackMoveMid);
        }
    }
    private IEnumerator ContinueAnimMoveSwap(List<DataItemSkillSwap> dataItemSkillSwaps, Action callback)
    {

        yield return new WaitForSeconds(0.15f);
        foreach (var it in dataItemSkillSwaps)
        {
            it.item.OnEndMoveSkillSwap(it.pointMove, callback, it.isNomal);
        }
        _fxClone.gameObject.SetActive(false);
        _fxBurtClone.gameObject.SetActive(false);
    }

    List<Item> GetListItemByCount(int count, List<Item> listLayer)
    {
        List<Item> listIem = new();
        for (int i = 0; i < count; i++)
        {
            if (listLayer.Count > 0)
            {
                var it = listLayer[0];
                listLayer.RemoveAt(0);
                listIem.Add(it);
            }
        }
        return listIem;
    }

   
    public IEnumerator StartAnim()
    {
        _anim.AnimationState.SetAnimation(0, "Start", false);

        yield return new WaitForSeconds(0.5f);

        if(_fxClone == null)
        {
            _fxClone = Instantiate(_fx.gameObject, transform).GetComponent<Transform>();
        }
        _fxClone.gameObject.SetActive(true);
        _fxClone.GetComponent<ParticleSystem>().Play();

        yield return new WaitForSeconds(0.5f);
        _anim.AnimationState.SetAnimation(0, "Start_Idle", false);
        yield return new WaitForSeconds(0.667f);
        if(_fxBurtClone == null)
        {
            _fxBurtClone = Instantiate(_fxBurt, transform);
        }
        _fxBurtClone.gameObject.SetActive(true);
        _fxBurtClone.Play();
        StartCoroutine(ContinueAnimMoveSwap(dataItemSkillSwaps, callbackMoveEnd));
        _anim.AnimationState.SetAnimation(0, "Stop", false);
    }
}
