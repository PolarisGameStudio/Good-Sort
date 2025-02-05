using UnityEngine;

public class UITutorialSystem : MonoBehaviour
{
	public CanvasGroup viewport;

	public UITutorialSystem_Phase[] phases;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	public UITutorialSystem_Phase StartTutorial(int phaseActive, string descripton = "")
	{
		return null;
	}

	public void StopTutorial()
	{
	}

	public bool IsInteractableTutorial()
	{
		return false;
	}

	public void SetInteractableTutorial(bool canClick, bool showAlpha)
	{
	}
}
