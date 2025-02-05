using System;
using System.Collections.Generic;
using UnityEngine;

public class UIStackActionManager : Singleton<UIStackActionManager>
{
	public class ActionPriority
	{
		public int priority;

		public Action action;

		public IDStackMenu id;

		public ActionPriority(int p, Action a, IDStackMenu i)
		{
		}
	}

	public RectTransform rectLock;

	public IDStackMenu[] stackIDs;

	public List<ActionPriority> actionList;

	private static Action OnCompleteStack;

	public static Action OnNoStack;

	private bool _hasAction;

	private ActionPriority actionPriority;

	private bool IsRunning;

	public ActionPriority GetHighestPriorityAction()
	{
		return null;
	}

	public void AddActionCompleteStack(Action onComplete)
	{
	}

	public void AddActionLockUI(Action onComplete)
	{
	}

	public void AddStack(Action action, IDStackMenu id)
	{
	}

	public void RemoveStack(IDStackMenu id)
	{
	}

	public void NextStack()
	{
	}

	public bool IsCompletedStack()
	{
		return false;
	}

	private void ExecuteTopStack()
	{
	}

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void Start()
	{
	}
}
