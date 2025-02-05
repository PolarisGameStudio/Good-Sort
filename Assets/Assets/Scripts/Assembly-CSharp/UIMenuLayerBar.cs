using UnityEngine;
using UnityEngine.UI;

public class UIMenuLayerBar : MonoBehaviour
{
	[SerializeField]
	private Button _buttonNextLayer;

	[SerializeField]
	private Button _buttonPreviousLayer;

	[SerializeField]
	private Text _textLayer;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void UpdateUIText(int currentLayer)
	{
	}

	private void OnClickNextLayer()
	{
	}

	private void OnClickPreviousLayer()
	{
	}
}
