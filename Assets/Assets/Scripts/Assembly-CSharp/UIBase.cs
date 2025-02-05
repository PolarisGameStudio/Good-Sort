using UnityEngine;
using UnityEngine.Events;

public class UIBase : MonoBehaviour
{
	[HideInInspector]
	public bool Visible;

	[Header("Events")]
	public UnityEvent OnInit;

	public UnityEvent OnShow;

	public UnityEvent OnHide;

	protected bool Initialized;

	public virtual void ChangeVisibility(bool visible, bool trivial = false)
	{
	}

	public virtual void ChangeVisibilityImmediate(bool visible, bool trivial = false)
	{
	}

	public void ChangeVisibility(bool visible)
	{
	}

	public void ChangeVisibilityImmediate(bool visible)
	{
	}

	public virtual void SwitchVisibility()
	{
	}

	public virtual void SwitchVisibilityImmediate()
	{
	}

	protected void DeactivateMe(bool forceInvisibility)
	{
	}

	protected void DeactivateMe()
	{
	}
}
