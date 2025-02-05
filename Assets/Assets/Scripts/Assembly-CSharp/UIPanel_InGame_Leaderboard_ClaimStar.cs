using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_InGame_Leaderboard_ClaimStar : MonoBehaviour
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

	public Machine machine;

	public float durationClaim;

	public Button btnCompleted;

	public TextMeshProUGUI txtStarCompleted;

	public Button btnWatchAds;

	public TextMeshProUGUI txtWatchAds;

	public TextMeshProUGUI txtStarWatchAds;

	private float c_bonusReward;

	private Coroutine coroutineMachine;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnWatchAdsComplete(int obj)
	{
	}

	public void UpdateUI(int star)
	{
	}

	private void StopMachine()
	{
	}
}
