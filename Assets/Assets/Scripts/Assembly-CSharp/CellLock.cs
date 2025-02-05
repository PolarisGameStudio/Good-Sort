using Spine.Unity;
using TMPro;
using UnityEngine;

public class CellLock : MonoBehaviour
{
	public RectTransform rectText;

	public TextMeshProUGUI textMesh;

	public SkeletonAnimation ske;

	public BoxCollider2D box;

	public ParticleSystem _fx;

	private int c_num;

	private void Awake()
	{
	}

	public void UpdateNumLock(int num)
	{
	}
}
