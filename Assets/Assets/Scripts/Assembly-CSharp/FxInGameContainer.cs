using UnityEngine;

public class FxInGameContainer : Singleton<FxInGameContainer>
{
	[SerializeField]
	private ParticleSystem[] _fxMatch3CombosNew;

	[SerializeField]
	private ParticleSystem _fxGoldenGift;

	[SerializeField]
	private ParticleSystem _fxGoldenGiftPress;

	public static int indexFx;

	public const string POOL_FX = "Fx";

	public void SpawnFxMatch3(Vector3 pos)
	{
	}

	public ParticleSystem GetFxGoldenGift(Transform parent)
	{
		return null;
	}

	public void SpawnFxGoldenGiftPress(Vector3 pos)
	{
	}
}
