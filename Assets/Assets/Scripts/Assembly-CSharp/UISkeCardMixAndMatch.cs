using Spine;
using Spine.Unity;
using UnityEngine;

public class UISkeCardMixAndMatch : MonoBehaviour
{
	public Material sourceMaterial;

	[Header("Face")]
	private Sprite faceSprite;

	[SpineSlot(null, null, false, true, false)]
	public string faceSlot;

	[Header("Name")]
	public Sprite nameSprite;

	[SpineSlot(null, null, false, true, false)]
	public string nameSlot;

	[Header("Do not assign")]
	public Texture2D runtimeAtlas;

	public Material runtimeMaterial;

	public Skin customSkin;

	private void OnValidate()
	{
	}

	public void UpdateUI_Info(Sprite sprFace, Sprite sprName)
	{
	}

	private void UpdateUI()
	{
	}
}
