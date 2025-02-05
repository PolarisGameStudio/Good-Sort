using System.Collections.Generic;
using Coffee.UIExtensions;
using UnityEngine;

public class UIPanel_Digging_Treasure_Table : MonoBehaviour
{
	public RectTransform rectTreasure;

	public List<UIPanel_Digging_Treasure_Table_Item> items;

	public UIParticle fxOpen;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnClaimRewardLevel(ItemInBoard itemInBoard)
	{
	}

	public void UpdateUI(int level)
	{
	}

	private void SetReadyToClaim()
	{
	}
}
