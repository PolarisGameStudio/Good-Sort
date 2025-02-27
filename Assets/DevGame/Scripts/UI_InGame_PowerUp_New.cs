using System;
using UnityEngine;
using UnityEngine.UI;

public class UI_InGame_PowerUp_New : MonoBehaviour
{
	[Serializable]
	public class PowerUpUI
	{
		public PowerupKind kind;

		public Sprite icon;

		public Sprite iconLock;

		public PowerUpUISlot uISlot;

		public void SetUp()
		{
		}
	}

	public Button[] btnSelects;

	public PowerUpUI[] powerUpUIs;

	public UITutorialSystem uiTutorialPowerUp;

	private void Start()
	{
	}

	private void OnUILoadingDone()
	{
	}

	private void OnPurchaseSusscess(string obj)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private PowerUpUI GetPowerUpUI(PowerupKind powerupKind)
	{
		return null;
	}

	private void UpdateUI()
	{
	}

	private void UpdateUI_SlotPowerUp(PowerupKind kind)
	{
	}

	private int GetIndexPowerUp(PowerupKind kind)
	{
		return 0;
	}

	private void UpdateUI_LockItem(PowerupKind kind)
	{
	}
}
