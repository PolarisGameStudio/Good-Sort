using DG.Tweening;
using TMPro;
using UnityEngine;

public class UIToastManager : MonoBehaviour
{
	public static UIToastManager Instance;

	public RectTransform rectPanel;

	public TextMeshProUGUI txtContent;

	public TextMeshProUGUI txtIDAndVer;

	private Vector2 _initPos;

	private Tween _tween;

	private Tween _tween1;

	private Coroutine _coroutine;

	private void Awake()
	{
	}

	private void UpdateInfo()
	{
	}

	private void OnLoginStateChange(bool obj)
	{
	}

	public void ShowNoAds()
	{
	}

	public void ShowConnectionError()
	{
	}

	public void Show(string content)
	{
	}
}
