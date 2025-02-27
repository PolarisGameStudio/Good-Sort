using UnityEngine;

[CreateAssetMenu(fileName = "SOLevel", menuName = "ScriptableObjects/SOLevel", order = 2)]
public class SOLevel : ScriptableObject
{
	public LevelInfo level;

	public void ValidateLevel()
	{
	}
}
