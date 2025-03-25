using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialGame : MonoBehaviour
{
    public static TutorialGame instance = null;
    [SerializeField] Cell celHand;
    [SerializeField] List<Item> ItemcelHand = null;
    [SerializeField] List<Transform> ItemcelMove = null;

    [SerializeField] List<Cell> cells = null;
    [SerializeField] List<Item> itemSucess0 = null;
    [SerializeField] List<Item> itemSucess1 = null;
    private Tween tweenCurrent = null;
    private int indexCureent = 0;
    Vector3 pointBegin = Vector3.zero;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        foreach(var ce in cells)
        {
            ce.ItemContainer.Cell = ce;
            LogicGame.Instance.AddCellToListCell(ce);
        }

        foreach(var item in itemSucess0)
        {
            item.itemContainer = cells[0].ItemContainer;
            item.itemContainer.Cell = cells[0];
        }

        foreach(var item in itemSucess1)
        {
            item.itemContainer = cells[1].ItemContainer;
            item.itemContainer.Cell = cells[1];
        }

        foreach(var item in ItemcelHand)
        {
            item.itemContainer = celHand.ItemContainer;
            item.itemContainer.Cell = celHand;
        }

        OnTutorialByIndex(0);
    }

    public void OnPauseAnim()
    {
        tweenCurrent.Kill();
        var objMove = ItemcelHand[indexCureent];
        objMove.gameObject.SetActive(false);
        objMove.transform.position = pointBegin;
    }

    public void OnContinueAnnim()
    {
        OnTutorialByIndex(indexCureent);
    }

    public void OnNextItem()
    {
        OnTutorialByIndex(indexCureent + 1);
    }

    void OnTutorialByIndex(int index)
    {
        if(index >= ItemcelHand.Count)
        {
            return;
        }
        indexCureent = index;

        var objMove = ItemcelHand[index];
        objMove.gameObject.SetActive(true);
        pointBegin = objMove.transform.position;
        cells[index].GetComponent<BoxCollider2D>().enabled = true;
        var objEnd = ItemcelMove[index];
        tweenCurrent = objMove.transform.DOMove(objEnd.transform.position, 1.0f).OnComplete(() => { 

        }).SetLoops(-1);
    }
}
