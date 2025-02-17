using UnityEngine;

public class MagicWard : MonoBehaviour
{
	[SerializeField] private Transform _tail1;
    [SerializeField] private GameObject _dotFlash;

    [SerializeField]
	private LineRenderer[] _lines;

	public void SetPos(Vector2 head, Vector2 tail)
	{
        transform.position = head;
        _dotFlash.transform.position = tail;
        var line1 = _lines[0];
        Vector3[] point1 = { head, tail };
        line1.SetPositions(point1);
        var line2 = _lines[1];
        Vector3[] point2 = { head, tail };
        line2.SetPositions(point2);
    }

   
}
