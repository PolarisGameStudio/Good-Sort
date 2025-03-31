using System;
using System.Collections;
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
	float cointReciver = 0;

	private void OnEnable()
	{
		machine.UpdateUI();
		btnCompleted.onClick.RemoveAllListeners();
		btnCompleted.onClick.AddListener(() => {
            OnComPlete();
        });

        btnWatchAds.onClick.RemoveAllListeners();
        btnWatchAds.onClick.AddListener(() => {
            StopMachine();
            AdsManager.Instance.ShowRewardBasedVideo((success) =>
            {
                if (success)
                {
					OnWatchAdsComplete(1);
                }
            }, "OnX2Coin");

        });

		float cointAds = 20;

		this.StartCoroutine(machine.IEStart(coint => {
            cointReciver = coint * cointAds;
			txtWatchAds.text = $"Complete X {(int)coint}";
            txtStarWatchAds.text = cointReciver.ToString();
        }));
    }

	private void OnDisable()
	{
	}

	private void OnWatchAdsComplete(int gold)
	{
		HelperManager.DataPlayer.currentCoin += (int)cointReciver * 2;
        StartCoroutine(OnLoadHomeScene());
    }

    public void UpdateUI(int gold)
	{
	}

	IEnumerator OnLoadHomeScene()
	{
		yield return new WaitForSeconds(1.0f);
        HelperManager.OnBackHomeScene();
    }

    public void OnComPlete()
	{
        StopMachine();
        HelperManager.DataPlayer.currentCoin += (int)cointReciver;

        StartCoroutine(OnLoadHomeScene());
       /* UIPopup_Booster.Show();
        UIPopup_Booster.Instance.callbackClose = () =>
        {
        };*/
    }

    private void StopMachine()
	{
        machine.Stop();

    }
}
