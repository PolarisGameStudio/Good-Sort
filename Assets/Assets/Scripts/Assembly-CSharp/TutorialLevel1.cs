using System;
using DG.Tweening;
using Spine.Unity;
using UnityEngine;

public class TutorialLevel1 : MonoBehaviour
{
	[SerializeField]
	private SkeletonAnimation _hand;

	[SerializeField]
	private Transform _handContainer;

	public SpriteRenderer icon;

	public Sprite[] sprIcons;

	private int step;

	private LevelController _levelController;

	private bool isActiveM3;

	private int _id;

	private Tween _tween;

	private Action _actionTut;

	private void OnDisable()
	{
	}

	public void Init(LevelController levelController)
	{
	}

	private void OnEndGame(EndGameState state)
	{
	}

	private void OnActiveM3(Vector2 vector)
	{
	}

	private void OnDestroy()
	{
	}

	public void ActiveBox(int cell, int index)
	{
	}

	public void StartTween(Vector2 pos1, Vector2 pos2, int id)
	{
	}

	public void KillAllTween()
	{
	}
}
