using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIMasterPass_BubbleInforItem_Manager : MonoBehaviour
{
	public Vector2 offsetPositionTarget;

	public float minArrowAnchorPosX;

	[Header("Elements Control")]
	public RectTransform rectItem;

	public RectTransform targetTop;

	public RectTransform[] arrows;

	[Header("Infor")]
	public TextMeshProUGUI txtDes;

	public UIPopup_ListRewards_Item[] rewards;

	private RectTransform c_TargetFollow;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private bool SetTarget(RectTransform targetFollow)
	{
		return false;
	}

	public void CloseItem()
	{
	}

	public void SetItem(RectTransform targetFollow, string strDes)
	{
	}

	public void SetItem_Chest(RectTransform targetFollow, List<ResourceValue> reward)
	{
	}

	private void Default()
	{
	}

	private RectTransform GetArrow()
	{
		return null;
	}

	public void ChangePosItem(float x, float y, float anchorPosArrow)
	{
	}

	public void ChangeSizeItem(float x, float y)
	{
	}
}
