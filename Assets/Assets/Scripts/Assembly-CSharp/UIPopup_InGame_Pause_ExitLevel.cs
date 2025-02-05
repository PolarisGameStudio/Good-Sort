using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_InGame_Pause_ExitLevel : MonoBehaviour
{
	[Serializable]
	public class Popup
	{
		public FeatureType type;

		public UIPopup popup;
	}

	public Button btnClosePopup;

	public Button btnQuit;

	public Popup[] popups;

	private List<FeatureType> c_ListFeatureActive;

	private void OnEnable()
	{
	}

	public void NextStack()
	{
	}

	public void CloseStack()
	{
	}
}
