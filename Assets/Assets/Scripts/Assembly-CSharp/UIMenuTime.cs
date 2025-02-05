using TMPro;
using UnityEngine;

public class UIMenuTime : MonoBehaviour
{
	[SerializeField]
	private TMP_InputField _inputFieldLevel;

	[SerializeField]
	private TMP_InputField _inputFieldLock;

	[SerializeField]
	private TMP_InputField _inputFieldItemHiden;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnImPort()
	{
	}

	private void OnChangeTime(string newValue)
	{
	}

	private void OnChangeNumLock(string newValue)
	{
	}

	private void OnChangeNumItemHiden(string newValue)
	{
	}
}
