using System.Collections.Generic;
using Coffee.UIExtensions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_GoldenGift_HomeProgress_Showcase : MonoBehaviour
{
	public class Params
	{
		public Transform parentHomeProgress;

		public UI_GoldenGift_HomeProgress homeProgress;

		public Image imgPoint;

		public int point;

		public void Reset()
		{
		}
	}

	public Image iconPoint;

	public TextMeshProUGUI txtPoint;

	public RectTransform tagX2Point;

	public RectTransform rectBoxReward;

	public Button btnClaim;

	public AnimationCurve curvePoint;

	public AnimationCurve curveReward;

	public RectTransform rectPoint;

	public UIParticle _fxBurst;

	private List<ResourceValue> c_ListRewardShowcase;

	private Params c_params;

	public void UpdateUI(Params param)
	{
	}

	private void DisableShowcase()
	{
	}
}
