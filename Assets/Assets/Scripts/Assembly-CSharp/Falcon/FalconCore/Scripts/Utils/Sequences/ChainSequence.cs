using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Falcon.FalconCore.Scripts.Utils.Sequences.Core;

namespace Falcon.FalconCore.Scripts.Utils.Sequences
{
	public class ChainSequence : Sequence
	{
	
		private readonly Sequence[] sequences;

		private Sequence runningSequence;

		public ChainSequence(params Sequence[] sequences)
		{
		}

		protected override void OnException(Exception e)
		{
		}

		protected override IEnumerator Enumerator()
		{
			return null;
		}
	}
}
