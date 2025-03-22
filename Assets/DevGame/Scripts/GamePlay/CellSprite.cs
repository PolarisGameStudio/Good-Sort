using UnityEngine;

public class CellSprite : MonoBehaviour
{
	[SerializeField]
	private Cell _cell;

	[SerializeField]
	private GameObject _left;

	[SerializeField]
	private GameObject _mid;

	[SerializeField]
	private GameObject _right;

	private void Start()
	{
	}

    public void OnEnableSpr(int index)
    {
        if(index == 0)
		{
            _left.gameObject.SetActive(true);
        }

        if (index == 1)
        {
            _mid.gameObject.SetActive(true);
        }

        if (index == 2)
        {
            _right.gameObject.SetActive(true);
        }
    }
}
