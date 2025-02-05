using System.Collections.Generic;
using Coffee.UIExtensions;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Collection_CardReceive : MonoBehaviour
{
	public UIPopup_Collection_CardReceive_Item[] items;

	public Button btnTapClaim;

	public Button btnTapContinue;

	[Header("Fx")]
	public UIParticle[] fxItemDisapears;

	[Header("Recycle Card -> Star")]
	public UIRect_UnlockCollection_Star_Recycle_Item[] starRecycles;

	public DOTweenAnimation tweenStarRecycle;

	public RectTransform rectIconChestRecycle;

	public ParticleSystem fxStarRecycle;

	private void OnDisable()
	{
	}

	public void UpdateUI(List<UserInfoSendCard> dataUsers, List<CardData> dataCards)
	{
	}
}
