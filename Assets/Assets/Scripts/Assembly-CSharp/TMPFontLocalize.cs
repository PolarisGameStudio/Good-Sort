using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TMPFontLocalize : MonoBehaviour
{
	[Serializable]
	public class Param
	{
		public string param;

		public string value;
	}

	[Header("Props")]
	public TextMeshProUGUI textMeshProUGUI;

	public Material material;

	[Header("I2")]
	public string term;

	public List<Param> paramTerms;

	public string preFix;

	public string surFix;

	private void Get()
	{
	}

	private void Set()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnLocalize()
	{
	}

	private void Init()
	{
	}

	public void SetTerm(string inputTerm)
	{
	}

	public void SetMaterial(Material inputMaterial)
	{
	}

	public TextMeshProUGUI TMP()
	{
		return null;
	}
}
