using System;
using System.Collections.Generic;
using UnityEngine;

public class UITutorialSystem_Phase : MonoBehaviour
{
	public Action<int> OnNextStep;

	public UITutorialSystem manager;

	public List<RectTransform> steps;

	private int currentStep;

	private bool isCanNextStep;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void Emit_NextStep(Transform rectStep = null)
	{
	}

	public void Emit_SetRectStepToIrisShot(RectTransform rectStep, RectTransform rectFitTarget)
	{
	}
}
