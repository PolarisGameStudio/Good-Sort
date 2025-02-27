using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class UIResource_PoolFly_Listing_Manager : Singleton<UIResource_PoolFly_Listing_Manager>
{
	public static Action OnForceUpdateUICache;

	public static Action<ResourceType, bool> OnPoolFlyUpdate;

	public static int s_Gold;

	public static int s_Star;

	public UIResource_PoolFly poolFly;

	public UIResource uiResource;

	public List<UIResource> lstUIResource;

	public RectTransform pointDefault;

	private Vector3 target;

	private bool IsAcceptLastUpdateFlyItemToTarget;

	[Header("Top Resource - Overlay")]
	public DOTweenAnimation tweenTopResourceOverlay;

	private int KeyTween_LastUpdateFlyToTarget => 0;

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnMinusGold(int goldMinus)
	{
	}

	private void OnFlyItemToTargetComplete(ResourceType kind, int numberAdd)
	{
	}

	public void KillLastUpdateFlyItemToTarget(bool forceUpdate = false)
	{
	}

	public bool IsClearFlyItemToTarget()
	{
		return false;
	}

	public void Spawn(ResourceType kindFly, Vector2 position, int number, int totalResources = 0)
	{
	}

	public void SpawnWithEndPosition(ResourceType kindFly, Vector3 position, Vector3 target, int number, int totalResources = 0)
	{
	}

	public void AddStackUIRs(UIResource uiRs)
	{
	}

	public void RemovestackUIRs(UIResource uiRs)
	{
	}

	public void ForceUpdateUI()
	{
	}

	public static void ForceUpdateUICache()
	{
	}

	public UIResource GetUIResource()
	{
		return null;
	}

	public void ForceShowTopResourceOverlay()
	{
	}
}
