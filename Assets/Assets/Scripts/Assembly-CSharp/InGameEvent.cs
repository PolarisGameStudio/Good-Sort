using System;
using UnityEngine;

public static class InGameEvent
{
	public static Action onGenLevelDone;

	public static Action onSelectItem;

	public static Action<Item> onStartMovedItem;

	public static Action<Item, Vector2, ItemContainer, ItemContainer> onDoneMovedItem;

	public static Action<Vector2> onActiveMatch3Item;

	public static Action<Vector2> onActiveMatch3ItemDelay;

	public static Action<Cell> onCellBecomeEmpty;

	public static Action<EndGameState> onEndGame;

	public static Action<bool> onTimeWarning;

	public static void ReleaseEvent()
	{
	}
}
