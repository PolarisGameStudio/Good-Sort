using UnityEngine;

public class MagicWard : MonoBehaviour
{
	[SerializeField] private Transform _tail1;

    [SerializeField]
	private LineRenderer[] _lines;

	public void SetPos(Vector2 head, Vector2 tail)
	{
        var objNew = Instantiate(_tail1.gameObject, transform);
        objNew.transform.position = Vector3.zero;
        transform.position = head;

        var line1 = _lines[0];
        Vector3[] point1 = { Vector3.zero, tail };
        line1.SetPositions(point1);
        var line2 = _lines[1];
        Vector3[] point2 = { Vector3.zero, tail };
        line2.SetPositions(point2);
    }

   
}
