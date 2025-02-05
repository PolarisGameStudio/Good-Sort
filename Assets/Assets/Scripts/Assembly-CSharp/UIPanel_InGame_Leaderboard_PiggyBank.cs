using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using TMPro;
using UnityEngine;

public class UIPanel_InGame_Leaderboard_PiggyBank : MonoBehaviour
{

	public RectTransform viewport;

	public RectTransform[] poolGolds;

	public TextMeshProUGUI txtGold;

	public Transform icon;

	private void OnEnable()
	{
	}

	public IEnumerator IEUpdateUI()
	{
		return null;
	}
}
