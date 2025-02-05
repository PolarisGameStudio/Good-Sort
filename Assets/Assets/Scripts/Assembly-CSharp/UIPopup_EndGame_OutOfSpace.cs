using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_EndGame_OutOfSpace : MonoBehaviour
{
	[Serializable]
	public class Popup
	{
		public FeatureType type;

		public UIPopup popup;
	}

	public UIPanel_EndGame_OutOfSpace_GetMore getmore;

	public Button btnExit;

	public UIPopup popupKeepChallenging;

	public Popup[] popups;

	private List<FeatureType> c_ListFeatureActive;

	private void OnEnable()
	{
	}

	public void NextStack()
	{
	}
}
