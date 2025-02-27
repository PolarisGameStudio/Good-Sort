using System;
using UnityEngine;

public class UIPopup 
{
	public bool isFullScreen;

	public bool isHalfFullScreen;

	[Header("The Watcher")]
	public bool DeactivateWhileInvisible;

	private CanvasGroup canvasGroup;

	private RectTransform viewport;

	private bool init;


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
