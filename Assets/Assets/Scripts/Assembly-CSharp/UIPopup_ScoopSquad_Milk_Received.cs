using System;
using System.Collections.Generic;
using Coffee.UIExtensions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_ScoopSquad_Milk_Received : MonoBehaviour
{
	public Action OnMilkFlyComplete;

	public RectTransform rectMilk;

	public UIParticle fxMilk;

	[SerializeField]
	private TextMeshProUGUI _txtMilk;

	[SerializeField]
	private GameObject _userInfoContainer;

	[SerializeField]
	private UIPopup_ScoopSquad_Milk_Received_Item _userInfoPrefab;

	[SerializeField]
	private Button _btnContinue;

	private List<UIPopup_ScoopSquad_Milk_Received_Item> _userInfos;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void UpdateUI()
	{
	}
}
