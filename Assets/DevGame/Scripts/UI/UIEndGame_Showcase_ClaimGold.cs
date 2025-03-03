using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

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

		private Tween t1, t2;

		public void UpdateUI()
		{
			var point = pointTarget.anchoredPosition;
			point = new Vector2 (point.x, -65);
			var pointEnd = txtTargets[txtTargets.Length - 1].GetComponent<RectTransform>().anchoredPosition;
            pointEnd = new Vector2(pointEnd.x, -65);
            target.anchoredPosition = point;
			RunAnim(pointEnd, point);
        }

		private void RunAnim(Vector2 p1, Vector2 p2)
		{
            t1 = target.DOAnchorPos(p1, duration).SetEase(curve).OnComplete(() => {
                t2 = target.DOAnchorPos(p2, duration).SetEase(curve).OnComplete(() => {
                    RunAnim(p1, p2);
                });
            });
        }

        public void Stop()
		{
			t1.Kill();
			t2.Kill();
        }

		public IEnumerator IEStart(Action<float> onBonusChange)
		{
			while(true)
			{
				var pointCurrentTaget = target.anchoredPosition;

				for(int i = 0; i < txtTargets.Length; i++)
				{
					var rect = txtTargets[i].GetComponent<RectTransform>();
					var point = rect.anchoredPosition;
					var size = rect.sizeDelta;
					var p1 = point.x + size.x / 2;
                    var p2 = point.x - size.x / 2;

					if(target.anchoredPosition.x > p2 && target.anchoredPosition.x < p1)
					{
						var cc = GetIndexNearestTargetToMarker(i);

						onBonusChange?.Invoke(cc);
                        break;
					}
                }
				yield return null;
            }
		}

		private int GetIndexNearestTargetToMarker(int index)
		{
			if(index >= targets.Length)
			{
				return 0;
			}
			return (int)targets[index];
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
		machine.UpdateUI();
		btnCompleted.onClick.RemoveAllListeners();
		btnCompleted.onClick.AddListener(() => {
            OnComPlete();
        });

        btnWatchAds.onClick.RemoveAllListeners();
        btnWatchAds.onClick.AddListener(() => {
			OnWatchAdsComplete(1);
        });
		this.StartCoroutine(machine.IEStart(coint => {
			txtStarWatchAds.text = (coint * 20).ToString();
        }));
    }

	private void OnDisable()
	{
	}

	private void OnWatchAdsComplete(int gold)
	{
		StopMachine();
    }

	public void UpdateUI(int gold)
	{
	}

	public void OnComPlete()
	{
        StopMachine();
    }

    private void StopMachine()
	{
        machine.Stop();

    }
}
