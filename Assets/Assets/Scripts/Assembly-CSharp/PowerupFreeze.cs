using Spine.Unity;
using UnityEngine;

public class PowerupFreeze : MonoBehaviour, IBooster
{
	public Transform fx;

	public SkeletonAnimation anim;

	private const float w = 6.2f;

	private const float h = 10.7f;

    public static int GetTimeFreeze()
	{
		return 0;
	}

	public void Active(LevelController levelController)
	{
	}

	private void OnEnable()
	{
        var sx = LogicGame.sizeCamera.x / (w * 2);
        var sy = LogicGame.sizeCamera.y / (h * 2);
        fx.localScale = new Vector3(sx, sy, 1);
        anim.AnimationState.SetAnimation(0, "animation", false);
    }

    private void OnDisable()
	{
	}

	private void EndGame(EndGameState state)
	{
	}
}
