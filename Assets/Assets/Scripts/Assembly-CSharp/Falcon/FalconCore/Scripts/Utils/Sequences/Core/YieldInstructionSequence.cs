using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Falcon.FalconCore.Scripts.Utils.Sequences.Core
{
	public class YieldInstructionSequence : Sequence
	{

		private bool flag;

		private YieldInstruction YieldInstruction { get; }

		public YieldInstructionSequence(YieldInstruction yieldInstruction)
		{
		}

		private IEnumerator Coroutine()
		{
			return null;
		}

		protected override IEnumerator Enumerator()
		{
			return null;
		}
	}
}
