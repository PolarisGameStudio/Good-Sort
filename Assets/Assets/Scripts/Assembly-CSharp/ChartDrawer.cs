using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ChartDrawer : MonoBehaviour
{
	public ChartItem columnPrefab;

	public Transform chartContainer;

	public Button btnSave;

	public Button btnLoad;

	public TMP_InputField inputField;


	private const string sheet_name = "Chart";

	private const string sheetName = "Chart";

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	public void DrawChart(List<float> values)
	{
	}
}
