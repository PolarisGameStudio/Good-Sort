using UnityEngine;
using UnityEngine.UI;

public class AvatarSelect : MonoBehaviour
{
	[SerializeField]
	private RawImage _ava;

	[SerializeField]
	private Button _button;

	[SerializeField]
	private RectTransform _rectSelected;

	public UIRect_Profile_FrameAvatar rectFrame;

	private int c_ID;

	private void Start()
	{
	}

	public void Setup(int id)
	{
	}

	public void SetAvatar(int id)
	{
	}

	public void SetAvatar(UserProfile data)
	{
	}

	public void SetSelected(int idSelected)
	{
	}
}
