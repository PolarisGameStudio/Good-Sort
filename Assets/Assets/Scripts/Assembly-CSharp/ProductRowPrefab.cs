
using UnityEngine;
using UnityEngine.UI;

public class ProductRowPrefab : MonoBehaviour
{
	[SerializeField]
	private RawImage _thumbImg;

	[SerializeField]
	private Text _titleText;

	[SerializeField]
	private Text _productIdText;

	[SerializeField]
	private GameObject _buyBtn;

	private LogScroller _logScroller;

	private void Awake()
	{
	}

	public void OnLogBtnClick()
	{
	}

	public void OnPurchaseBtnClick()
	{
	}

	private void SetThumb(string productId, string url)
	{
	}

	private void LogText(string text)
	{
	}
}
