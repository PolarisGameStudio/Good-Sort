using System;
using Spine;
using Spine.Unity;
using UnityEngine;


public class UIPanel_StallBuilding_Decoration_Item : MonoBehaviour
{
	public SkeletonGraphic skePreview;

	public RectTransform targetHold;

	[Header("Ref - Anim Addon")]
	public SkeletonGraphic refSkePreviewAddon;

	private TrackEntry trackPreviewOpen;

	public bool c_IsRunningAnimPreview;

	public void SetItemActive(bool isActive)
	{
	}

	public void SetItemData(UIPanel_StallBuilding_Decoration manager, int itemIndex)
	{
	}

	public void UnlockPreviewAnimation(int indexSkin, Action OnComplete)
	{
	}

	public void ChangeSkinPreviewAnimation(int indexSkin)
	{
	}

	public void PlayPreviewAnimation()
	{
	}

	public void RefreshPreviewAnimation(float delay)
	{
	}
}
