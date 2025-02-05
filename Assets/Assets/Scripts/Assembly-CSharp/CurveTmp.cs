using TMPro;
using UnityEngine;

[ExecuteAlways]
public class CurveTmp : MonoBehaviour
{
	[SerializeField]
	private TMP_Text text;

	[Tooltip("Use Bounds based on RectTransform (true) or TextBounds (false).")]
	public bool dependOnRectBound;

	public AnimationCurve vertexCurve;

	public float yCurveScaling;

	private bool isForceUpdatingMesh;

	private bool _isStart;

	private void Reset()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void RefreshText()
	{
	}

	private void ReactToTextChanged(Object obj)
	{
	}

	public void WarpText()
	{
	}
}
