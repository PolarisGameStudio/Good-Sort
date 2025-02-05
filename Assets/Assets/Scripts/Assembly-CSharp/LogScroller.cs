using System.Collections.Generic;
using UnityEngine;

public class LogScroller : MonoBehaviour
{
	[SerializeField]
	private GameObject _content;

	[HideInInspector]
	public List<string> texts;

	private string DATE_FORMAT;

	private int index;

	private void Start()
	{
	}

	public void ClearLogs()
	{
	}

	public void Log(string text)
	{
	}
}
