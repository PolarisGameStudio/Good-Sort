using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIThemeIngame : MonoBehaviour
{
	[Serializable]
	public class UITheme
	{
		public Image topBarCenter;

		public Image topBar9Slice;

		public Image topBarOverlay;

		public Image[] topBarBorderBgs;

		public TextMeshProUGUI[] topBarTexts;
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
