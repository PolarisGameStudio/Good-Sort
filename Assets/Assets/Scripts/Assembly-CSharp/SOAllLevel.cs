using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SOAllLevel", menuName = "ScriptableObjects/SOAllLevel", order = 3)]
public class SOAllLevel : ScriptableObject
{
	public List<LevelInfoEditor> levelInfos;
}
