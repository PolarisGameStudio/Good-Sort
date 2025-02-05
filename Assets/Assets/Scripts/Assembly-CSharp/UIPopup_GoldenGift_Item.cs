using System;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_GoldenGift_Item : MonoBehaviour
{
	[Serializable]
	public class Reward
	{
		public UIPopup_ListRewards_V2_Item item;

		public RectTransform fxCurrent;

		public RectTransform[] fxCanClaims;

		public void State_FxCanClaim(bool isActive)
		{
		}
	}

	public Image progressSTT;

	public Image bgSTT;

	public Sprite[] sprSTTs;

	public TextMeshProUGUI txtSTT;

	public Reward reward;

	public RectTransform fxCurrentNumber;

	public SkeletonGraphic skeClaimed;

	public SkeletonGraphic skeLock;

	public RectTransform fxUnlock;

	public Button btnInfo;

	public RectTransform rectCurrent;

	public Slider[] lineCurrents;

	public RectTransform bgLineBottom;

	private void OnDisable()
	{
	}

	public void SetItemData(int index, ResourceValue data, int prePoint)
	{
	}

	private void IsCurrent()
	{
	}

	public void TweenClaim()
	{
	}

	public void TweenReadyClaim()
	{
	}
}
