using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BoosterX2Star : MonoBehaviour
{
	public void Active()
	{
		LogicGame.Instance.OnBossterX2Start();
    }
	
}
