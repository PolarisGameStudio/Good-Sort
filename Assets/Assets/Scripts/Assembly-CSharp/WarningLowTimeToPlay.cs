using Unity.VisualScripting;
using UnityEngine;

public class WarningLowTimeToPlay : MonoBehaviour
{
	public Transform fx;

	private void Awake()
	{
	}

    public void SetActiveFx(bool isActive)
    {
        fx.gameObject.SetActive(isActive);
    }

    private void OnEnable()
    {
    }

}
