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
	}

	private void OnDisable()
	{
	}

	private void EndGame(EndGameState state)
	{
	}
}
