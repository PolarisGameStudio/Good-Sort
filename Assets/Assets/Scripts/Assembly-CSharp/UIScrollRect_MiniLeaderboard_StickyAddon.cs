using UnityEngine;
using UnityEngine.UI;

public class UIScrollRect_MiniLeaderboard_StickyAddon : MonoBehaviour
{
	public VerticalLayoutGroup layoutStoreSticky;

	public float offsetYViewport;

	private UIScrollRect_MiniLeaderboard manager;

	private RectTransform rectLayoutStoreSticky;

	private RectTransform itemScrollRectReference;

	private Vector3[] viewportCorners;

	private Vector3[] itemCorners;

	private Vector3[] itemSticky;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void OnValueScrollChanged()
	{
	}

	private bool IsOutsideViewport()
	{
		return false;
	}

	public void SetItemToSticky(RectTransform item)
	{
	}

	public void ActiveSticky()
	{
	}

	public void DeactiveSticky()
	{
	}
}
