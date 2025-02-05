using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopupForceUpdate : MonoBehaviour
{
	[SerializeField]
	private GameObject[] _buttonCloses;

	[SerializeField]
	private Button _buttonUpdate;

	[SerializeField]
	private TextMeshProUGUI _textDes;

	private Vector2 _initPos;

	private void Awake()
	{
	}

	private void OpenStore()
	{
	}

	public void OnForceUpdate(int type, string stargetVersion)
	{
	}
}
