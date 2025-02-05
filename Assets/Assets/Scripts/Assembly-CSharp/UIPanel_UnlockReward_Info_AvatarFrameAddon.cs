using UnityEngine;
using UnityEngine.UI;

public class UIPanel_UnlockReward_Info_AvatarFrameAddon : MonoBehaviour
{
	public Image avatar;

	public RawImage rawAvatar;

	public UIRect_Profile_FrameAvatar rectFrame;

	[Header("Init Frame")]
	public bool initByUser;

	public int frameIdAuto;

	private void OnEnable()
	{
	}

	public void UpdateUI(int frameIndex)
	{
	}
}
