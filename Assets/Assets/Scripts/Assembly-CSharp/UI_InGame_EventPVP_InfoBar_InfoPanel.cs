using System;
using System.Collections.Generic;
using Coffee.UIExtensions;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_InGame_EventPVP_InfoBar_InfoPanel : MonoBehaviour
{
	[Serializable]
	public class SpriteByPercent
	{
		public float hpPercent;

		public Sprite spritePercent;
	}

	[Serializable]
	public class SkinByPercent
	{
		public float hpPercent;

		[SpineSkin(null, null, true, false, false)]
		public string skinName;
	}

	[SerializeField]
	private Image _avatar;

	[SerializeField]
	private UIRect_Profile_FrameAvatar _frame;

	[SerializeField]
	private Text _name;

	[SerializeField]
	private TextMeshProUGUI _hp;

	[SerializeField]
	private UIParticle _fxHealthBar;

	[SerializeField]
	private UIParticle _fxHealthBar_Outline;

	[SerializeField]
	private Slider _sliderHp;

	[SerializeField]
	private Image _imageSliderHp;

	[SerializeField]
	private Slider _sliderHpShadow;

	[SerializeField]
	private Image _imageSliderHpShadow;

	[SerializeField]
	private List<SpriteByPercent> _spriteByPercents;

	[SerializeField]
	private SkeletonGraphic _avatarAnim;

	[SerializeField]
	private List<SkinByPercent> _skinPhases;

	private int _truncateNameLength;

	private string _truncateNameLengthWithDots;

	public void UpdateUIProfile(UserProfile userProfile)
	{
	}

	private string TruncateName(string name, int maxLength, string truncationSuffix)
	{
		return null;
	}

	public void UpdateUIHp(long currentHp, long maxHp)
	{
	}

	private void UpdateUIValueHp(long currentHp, long maxHp)
	{
	}

	public void PlayFxHpBar()
	{
	}

	private void UpdateUISpriteHp(long currentHp, long maxHp)
	{
	}

	public Vector2 GetAvatarPosition()
	{
		return default(Vector2);
	}

	public void UpdateUIAvatarAnim(float healthPercent)
	{
	}

	private int DeterminePhase(float healthPercent)
	{
		return 0;
	}
}
