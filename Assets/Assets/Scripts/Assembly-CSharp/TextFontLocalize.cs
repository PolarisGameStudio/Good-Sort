using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFontLocalize : MonoBehaviour
{
	[Serializable]
	public class Param
	{
		public string param;

		public string value;
	}

	public Text text;

	[Header("I2")]
	public string term;

	public List<Param> paramTerms;

	public string preFix;

	public string surFix;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnLocalize()
	{
	}

	public void SetTerm(string inputTerm)
	{
	}
}
