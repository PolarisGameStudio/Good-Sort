using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
	[SerializeField]
	private Button _backBtn;

	[SerializeField]
	private Sprite _mutedSprite;

	[SerializeField]
	private Sprite _volumeSprite;

	[SerializeField]
	private Image _mutedBtnImg;

	[SerializeField]
	private AudioSource _bgMusic;

	[SerializeField]
	private GameObject _pages;

	private GameObject _currentPage;

	private LogScroller _logScroller;

	private bool _muted;

	private Stack<GameObject> _pagesStack;

	private void Awake()
	{
	}

	public void NavToPage(string pageName)
	{
	}

	public void OnBackBtnClick()
	{
	}

	public void OnToggleMuteBtnClick()
	{
	}

	private GameObject _FindChild(Transform target, string name)
	{
		return null;
	}

	private void _LogText(string text)
	{
	}

	private void _SetMuteBtnIcon()
	{
	}
}
