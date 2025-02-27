using UnityEngine;
using UnityEngine.UI;

public class UIActiveBoosterStar : MonoBehaviour
{
	[SerializeField]
	private Sprite _x2Star;

	[SerializeField]
	private Image _imageStar;

	[SerializeField]
	private Transform _target;

	[SerializeField]
	private GameObject _fx;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void ActiveBooster(BoosterKind kind)
	{
	}
}
