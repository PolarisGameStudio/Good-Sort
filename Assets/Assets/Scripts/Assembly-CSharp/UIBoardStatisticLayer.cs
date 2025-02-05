using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIBoardStatisticLayer : MonoBehaviour
{
	public TextMeshProUGUI textLayerDes;

	public UIBoardStatisticLayerItem item;

	public GameObject content;

	public int layer;

	public SOItem sOItem;

	private List<UIBoardStatisticLayerItem> items;

	public void SetUp(int layer, Dictionary<ItemType, int> itemNumber)
	{
	}
}
