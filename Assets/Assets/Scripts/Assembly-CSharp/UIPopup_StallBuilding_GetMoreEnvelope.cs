using UnityEngine;

public class UIPopup_StallBuilding_GetMoreEnvelope : MonoBehaviour
{
	public RectTransform rectX2;

	public UITimerCountdownTMP timerX2;

	public UIPopup_StallBuilding_GetMoreEnvelope_Item[] items;

	[Header("Tween")]
	public RectTransform[] itemBuyPacks;

	public RectTransform tagHot;

	private Vector3[] anchorPosOriginals;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnBuyEnvelope(int index)
	{
	}

	private void UpdateUI()
	{
	}
}
