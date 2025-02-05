using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIEndGame_Showcase_ClaimGold : MonoBehaviour
{
	[Serializable]
	public class Machine
	{
	
		public float[] targets;

		public float duration;

		public Ease curve;

		public TextMeshProUGUI[] txtTargets;

		public RectTransform target;

		public RectTransform pointTarget;

		public void UpdateUI()
		{
		}

		public void Stop()
		{
		}

		public IEnumerator IEStart(Action<float> onBonusChange)
		{
			return null;
		}

		private int GetIndexNearestTargetToMarker(Transform marker)
		{
			return 0;
		}
	}

	[Serializable]
	public class GoldFlyItem
	{
		public RectTransform rectItem;

		public TextMeshProUGUI txtValue;

		public void Fire(int value)
		{
		}
	}

	public Machine machine;

	public float durationClaim;

	public Button btnCompleted;

	public TextMeshProUGUI txtStarCompleted;

	public Button btnWatchAds;

	public TextMeshProUGUI txtWatchAds;

	public TextMeshProUGUI txtStarWatchAds;

	public GoldFlyItem completeGoldFlyItem;

	public GoldFlyItem watchAdsGoldFlyItem;

	private float c_bonusReward;

	private Coroutine coroutineMachine;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnWatchAdsComplete(int gold)
	{
	}

	public void UpdateUI(int gold)
	{
	}

	private void StopMachine()
	{
	}
}
