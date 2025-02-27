using UnityEngine;
using UnityEngine.Events;

public class UIMenu : UIBase
{
	[Header("The Watcher")]
	public float hidingTime;

	public bool DeactivateWhileInvisible;

	public UIMenu PreviousMenu;

	public UIMenu NextMenu;

	[Header("Override Back - Ignore Previous Menu")]
	public bool isOverrideBack;

	public UnityEvent onOverrideBack;

	public override void ChangeVisibility(bool visible, bool trivial = false)
	{
	}

	public override void ChangeVisibilityImmediate(bool visible, bool trivial = false)
	{
	}

	private void InitializeElements()
	{
	}
}
