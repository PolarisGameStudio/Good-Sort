using Spine.Unity;
using System;
using System.Collections;
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
		c_num = 4;
		textMesh.text = "4";
    }

	public void UpdateNumLock(int num)
	{
		c_num--;
		textMesh.text = c_num.ToString();

		ske.AnimationState.SetAnimation(0, "Step" + num.ToString() + "_Off", false);
        ske.AnimationState.AddAnimation(0, "Step" + (num + 1).ToString() + "_Idle", true, 0);
        if (c_num == 0)
		{
			this.StartCoroutine(UnLock());
			
		}
    }

	IEnumerator UnLock()
	{
        var obj = Instantiate(_fx, transform);
		obj.transform.localPosition = Vector3.zero;
		yield return new WaitForSeconds(GetAnimationDuration());
		Destroy(gameObject);

    }

    float GetAnimationDuration()
    {
        var animation = ske.Skeleton.Data.FindAnimation("Step4_Off");
        return animation != null ? animation.Duration : 0f;
    }
}
