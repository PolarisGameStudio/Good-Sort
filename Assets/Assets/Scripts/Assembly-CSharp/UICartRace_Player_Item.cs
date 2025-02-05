using System;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UICartRace_Player_Item : MonoBehaviour
{
	public UIPopup_CartRace refManager;

	public Image bgName;

	public Sprite[] bgBGNames;

	public Text txtName;

	public Color[] colorNames;

	public Text txtNamePremium;

	public Image avatar;

	public UIRect_Profile_FrameAvatar rectFrameAvatar;

	public UIRect_Profile_Badge rectBadge;

	[Header("Score")]
	public Slider progress;

	public SkeletonGraphic skeStar;

	public BoneFollowerGraphic boneSkeStar;

	public RectTransform rectFxSmoke;

	public Image imgTag;

	public Sprite[] sprTags;

	public TextMeshProUGUI txtTag;

	public Color[] colorTags;

	[Header("Rank")]
	public Button btnRank;

	public Image iconRankShadow;

	public Sprite[] sprIconRankShadows;

	public Image iconRank;

	public Sprite[] sprIconRanks;

	[Header("Tile")]
	public RectTransform rectTile;

	public HorizontalLayoutGroup layoutTile;

	public Image[] iconTileTypes_1;

	public Image[] iconTileTypes_2;

	public Sprite[] sprTileMines;

	public Sprite[] sprTileOthers;

	private Transform c_TargetRectBGLand;

	private CartRaceUserInfo c_data;

	private int c_PreRank;

	private int c_CurrentRank;

	public void SetTileArragangement(HorizontalLayoutGroup bgLand)
	{
	}

	public void SetItemData(CartRaceUserInfo data, (int, int) rank)
	{
	}

	public void Tween_AppearIdle()
	{
	}

	public void Tween_Appear(float delay)
	{
	}

	public void Tween_NextLevel(float delay, Action onRunComplete)
	{
	}

	public void Lose()
	{
	}

	private void Update()
	{
	}
}
