using UnityEngine;

public class UIChest_PatternPositionReward_Item : MonoBehaviour
{
	public RectTransform[] patterns;

	public RectTransform GetPattern(int numberReward)
	{
		if(numberReward - 1 >= patterns.Length)
		{
			return null;
		}
		return patterns[numberReward - 1];

	}

	public Vector3 GetPositionItem(RectTransform pattern, int index)
	{
		return default(Vector3);
	}
}
