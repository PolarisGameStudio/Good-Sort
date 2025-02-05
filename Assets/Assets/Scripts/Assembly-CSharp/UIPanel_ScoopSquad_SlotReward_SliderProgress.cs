using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIPanel_ScoopSquad_SlotReward_SliderProgress : MonoBehaviour
{

	[Header("Slider")]
	public Slider slider;

	public float[] stageValues;

	public float duration;

	public float delayBetweenStages;

	[Header("Event")]
	public UnityEvent eventOnStopSlider;

	private float valueSliderSecond;

	private Tween sliderTween;

	private bool shouldContinue;

	private int currentStageIndex;

	public void UpdateUI(float currentValue, float nextValue)
	{
	}

	public void UpdateUI_ForceValue(float currentValue)
	{
	}

	public void ContinueSlider()
	{
	}

	private IEnumerator HandleSlider()
	{
		return null;
	}
}
