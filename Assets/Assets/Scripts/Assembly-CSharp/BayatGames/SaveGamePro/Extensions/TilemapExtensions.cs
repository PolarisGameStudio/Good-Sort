using UnityEngine;
using UnityEngine.Tilemaps;

namespace BayatGames.SaveGamePro.Extensions
{
	public static class TilemapExtensions
	{
		public static T[] GetTiles<T>(this Tilemap tilemap) where T : TileBase
		{
			return null;
		}

		public static T[] GetTiles<T>(this Tilemap tilemap, out Vector3Int[] positions) where T : TileBase
		{
			positions = null;
			return null;
		}
	}
}
