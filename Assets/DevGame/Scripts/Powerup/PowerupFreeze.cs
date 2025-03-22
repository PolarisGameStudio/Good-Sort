using DG.Tweening;
using Spine.Unity;
using System.Collections;
using UnityEngine;

public class PowerupFreeze : MonoBehaviour
{
	public Transform fx;

	public SkeletonAnimation anim;

	private const float w = 6.2f;

	private const float h = 10.7f;

    public static int GetTimeFreeze()
	{
		return 0;
	}

	private void OnEnable()
	{
        anim.gameObject.SetActive(true);
        anim.transform.position += new Vector3(0, 2, 0);
        var sx = LogicGame.sizeCamera.x / (w * 2);
		var sy = LogicGame.sizeCamera.y / (h * 2);
		fx.localScale = new Vector3(sx, sy, 1);
        anim.AnimationState.SetAnimation(0, "animation", false);
        anim.transform.DOMove(Vector3.zero, 0.25f).SetEase(Ease.InOutQuad).OnComplete(() => {
        });
		StartCoroutine(DelayDisable());
    }

	IEnumerator DelayDisable()
	{
		yield return new WaitForSeconds(2.0f);
        anim.gameObject.SetActive(false);

    }

    private void OnDisable()
	{
		anim.transform.position += new Vector3(0, 2, 0);
    }

	private void EndGame(EndGameState state)
	{
	}
}
