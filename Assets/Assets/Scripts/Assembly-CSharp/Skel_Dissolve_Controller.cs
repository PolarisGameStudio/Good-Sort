using Spine.Unity;
using UnityEngine;

public class Skel_Dissolve_Controller : MonoBehaviour
{
	[Header("Materials")]
	public Material originalMaterial;

	public Material[] materials;

	private void OnDisable()
	{
	}

	public void SetCutoff(SkeletonGraphic ske, int skinIndex)
	{
	}
}
