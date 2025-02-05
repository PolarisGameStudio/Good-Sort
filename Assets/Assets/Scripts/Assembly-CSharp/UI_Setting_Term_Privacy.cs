using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Setting_Term_Privacy : MonoBehaviour
{
	[Serializable]
	public class ButtonUnderLine
	{
		public Button button;

		public RectTransform underLine;

		public TextMeshProUGUI txt;

		public void UpdateUnderLine()
		{
		}
	}

	public RectTransform rectContent;

	public ButtonUnderLine btnTerm;

	public ButtonUnderLine btnPrivacy;

	public ButtonUnderLine btnDeleteAccount;

	public ButtonUnderLine btnRestorePurchases;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void UpdateRectSize()
	{
	}

	private void UpdateUnderLine()
	{
	}
}
