using System;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class UIPopup : UIBase
{
	public bool isFullScreen;

	public bool isHalfFullScreen;

	[Header("The Watcher")]
	public bool DeactivateWhileInvisible;

	private CanvasGroup canvasGroup;

	private RectTransform viewport;

	private bool init;

	public override void ChangeVisibility(bool visible, bool trivial = false)
	{
	}

	public override void ChangeVisibilityImmediate(bool visible, bool trivial = false)
	{
	}

	private void InitializeElements()
	{
	}

	public void OnClick_CloseThisPopup()
	{
	}

	public void OnClick_CloseThisPopup(Action onHide)
	{
	}

	public void ShowTween()
	{
	}

	public void ShowTween_2()
	{
	}

	public void HideTween()
	{
	}

	private void Init()
	{
	}
}
