using System;
using Spine.Unity;
using UnityEngine;

public class UI_InGame_EventPVP_Home_PoorFly_Damage_Item : MonoBehaviour
{
	[SerializeField]
	private SkeletonGraphic _skeGraphic;

	private float _speed;

	public SkeletonGraphic SkeGraphic => null;

	public void JumpToTarget(Vector2 spawnPos, Vector2 targetPos, Action onComplete)
	{
	}
}
