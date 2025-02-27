using UnityEngine;

public class CellMove : MonoBehaviour
{
	private MoveType _moveType;

	private float _speed;

	public Cell cell;

	public MoveType MoveType => default(MoveType);

	public float Speed => 0f;

	public void SetupData(Cell cell, MoveType type, float speed)
	{
	}

	public void PerformUpdate(float maxX, float maxY, float deltaTime)
	{
	}
}
