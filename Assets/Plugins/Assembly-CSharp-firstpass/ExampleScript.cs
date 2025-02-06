using UnityEngine;
using UnityEngine.UI;

public class ExampleScript : MonoBehaviour
{
	public Text m_DeviceTimeLabel;

	public Text m_EstimatedTimeLabel;

	public GameObject m_UnsupportedPlatform;

	public GameObject m_TimeSource;

	public Toggle m_UsingDeviceTime;

	public Toggle m_UsingEstimatedTime;

	public Toggle m_UsingServerTime;

	public Button m_SaveTimeStampButton;

	public Button m_LoadTimeStampButton;

	public Text m_TimeSinceTimeStampLabel;

	private float m_UpdateTimer;

	private void Start()
	{
	}

	private void OnApplicationFocus(bool focus)
	{
	}

	private void InitTimeStampLogic()
	{
	}

	private void OnCheatFreeTimeAvailable()
	{
	}

	private void Update()
	{
	}

	public void OnSaveTimeStamp_Pressed()
	{
	}

	public void OnLoadTimeStamp_Pressed()
	{
	}
}
