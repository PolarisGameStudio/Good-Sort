using DG.Tweening;
using SuperScrollView;
using UnityEngine;
using UnityEngine.UI;

public class UIScrollRectSnapToChild : MonoBehaviour
{
	public float padding;

	public Ease ease;

	private ScrollRect scrollRect;

	private LoopGridView loopGridView;

	public void SnapTo(Transform child, float duration = 0.25f)
	{
	}

	public void SnapTo_V2(Transform child, float duration = 0.25f)
	{
	}

	public void ChangeEase(Ease easing)
	{
	}

	public void SnapToUseSuperGridView(int itemIndex, float duration = 0.25f)
	{
	}
}
