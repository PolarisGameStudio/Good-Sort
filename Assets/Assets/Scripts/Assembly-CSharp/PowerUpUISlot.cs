using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpUISlot : MonoBehaviour
{
	public Sprite[] bgStates;

	public Image bg;

	public Button btnSelect;

	public Image iconUnLock;

	public RectTransform rectUnLock;

	public TextMeshProUGUI txtNumber;

	public RectTransform rectIconMore;

	public RectTransform rectIconFree;

	public RectTransform rectLock;

	public Image iconLock;

	public TextMeshProUGUI txtLevelUnlock;

	private PowerupKind c_powerupKind;

	private Sprite c_spriteIconLock;

	public void ForceLock()
	{
	}

	public void SetUp(PowerupKind kind, Sprite spriteIconLock, Sprite spriteIcon)
	{
	}
}
