using System;
using UnityEngine;

public class GoldenGiftInGameController : Singleton<GoldenGiftInGameController>
{
	private int _goldenGift;

	public Item ItemGoldenGift;

	public Action<Vector2> onAddItem;

	public int GoldenGift => 0;

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	public Vector2 GetPosItemGoldenGiftForTut()
	{
		return default(Vector2);
	}

	public void SelectItem()
	{
	}

	private void EndGame(EndGameState state)
	{
	}

	public void AddGoldenGift(Vector3 pos)
	{
	}
}
