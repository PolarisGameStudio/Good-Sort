using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIRecommenPowerup : MonoBehaviour
{
	[Serializable]
	public class Toast
	{
		public RectTransform container;

		public TextMeshProUGUI text;

		public Button buttonClose;

		public void Active(bool active)
		{
		}

		public void Active(bool active, string content)
		{
		}

		public void KillTween()
		{
		}
	}

	[Serializable]
	public class UIRecommend
	{
		public PowerupKind powerup;

		public Image border;

		public Image icon;

		public void Active()
		{
		}

		public void DeActive()
		{
		}

		public void KillTween()
		{
		}
	}

	[SerializeField]
	private RecommenPowerup _recommend;

	[SerializeField]
	private Toast _toast;

	[SerializeField]
	private UIRecommend[] _uiRecommend;

	private UIRecommend _currentUIRecommend;

	private bool _isStuckInLayer;

	private void Awake()
	{
	}

	private void GenLevelDone()
	{
	}

	private void OnCellChangeLayer()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnActiveItem(PowerupKind powerupKind)
	{
	}

	private void OnCloseToastItem()
	{
	}

	private void OnDisableItem()
	{
	}

	private void OnStuckInLayer()
	{
	}

	private void OnActivePowerup(PowerupKind kind)
	{
	}

	private void DeActiveStuck()
	{
	}
}
