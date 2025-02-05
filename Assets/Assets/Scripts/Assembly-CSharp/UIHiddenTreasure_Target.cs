using System.Collections.Generic;
using Spine.Unity;
using UnityEngine;

public class UIHiddenTreasure_Target : MonoBehaviour
{
	public SkeletonGraphic BG;

	public RectTransform rectPoints;

	public UIHiddenTreasure_Player pointMain;

	public UIHiddenTreasure_Player[] points;

	public RectTransform[] rectTargetDrops;

	public RectTransform tweenLand;

	private int c_IndexPoint;

	private int c_IndexDropPoint;

	private void Start()
	{
	}

	public void Reset()
	{
	}

	public RectTransform GetPointMain()
	{
		return null;
	}

	public RectTransform GetPoint()
	{
		return null;
	}

	public RectTransform GetDropPoint()
	{
		return null;
	}

	public Vector3 GetScaleTarget()
	{
		return default(Vector3);
	}

	public void Land_Hit_Start()
	{
	}

	public void Land_Hit(float delayValue)
	{
	}

	public void Land_Hit_Trigger(int count, float duration)
	{
	}

	public void Land_Hit_End()
	{
	}

	public void Show_Land()
	{
	}

	public void Disable_Land()
	{
	}

	public void Appear_Land(float delay)
	{
	}

	public void Drop_Land()
	{
	}

	public List<UIHiddenTreasure_Player> GetAllPoint()
	{
		return null;
	}
}
