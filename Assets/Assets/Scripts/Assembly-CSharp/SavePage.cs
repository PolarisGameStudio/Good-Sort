using UnityEngine;
using UnityEngine.UI;

public class SavePage : MonoBehaviour
{
	[SerializeField]
	private Button _saveLogBtn;

	[SerializeField]
	private InputField _customInputField;

	[SerializeField]
	private Button _appendDataBtn;

	private string LOGS_FOLDER_PATH;

	private string PLAYER_PREFS_PATH;

	private string SAVE_FILE_PATH;

	private LogScroller _logScroller;

	private void Awake()
	{
	}

	public void OnLogPlayerPrefsBtnClick()
	{
	}

	public void OnSavePlayerPrefsBtnClick()
	{
	}

	public void OnDeleteLogFilesBtnClick()
	{
	}

	public void OnSaveLogsBtnClick()
	{
	}

	public void OnAppendSaveFileBtnClick()
	{
	}

	public void OnDeleteSaveFileBtnClick()
	{
	}

	public void OnLogSaveFileBtnClick()
	{
	}

	public void OnLogSaveFilePathBtnClick()
	{
	}
}
