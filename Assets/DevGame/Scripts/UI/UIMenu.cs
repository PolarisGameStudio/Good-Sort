using UnityEngine;
using UnityEngine.Events;

public class UIMenu : MonoBehaviour
{
	[Header("The Watcher")]
	public float hidingTime;

	public bool DeactivateWhileInvisible;

	public UIMenu PreviousMenu;

	public UIMenu NextMenu;

	[Header("Override Back - Ignore Previous Menu")]
	public bool isOverrideBack;

	public UnityEvent onOverrideBack;

	private void InitializeElements()
	{
	}
}
