using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIAutoFill : MonoBehaviour
{
	public TMP_InputField m3;

	public TMP_InputField m2;

	public TMP_InputField m1;

	public TMP_InputField m3L2;

	public TMP_InputField m2L2;

	public TMP_InputField m1L2;

	public TMP_InputField m3In2L;

	public GameObject Layer2Container;

	public TextMeshProUGUI textLayer;

	public Toggle toggleFillItemInPreLayer;

	public Button button;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnChangeLayer(int layer)
	{
	}

	private void ActiveByLayer(bool isLayer1_2)
	{
	}

	private void Start()
	{
	}

	private int TotalSlot()
	{
		return 0;
	}

	private void OnValueChange(TMP_InputField t, int mul)
	{
	}
}
