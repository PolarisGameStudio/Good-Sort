using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Falcon.FalconCore.Scripts.Utils.Sequences.Core;

namespace Falcon.FalconCore.Scripts.Utils.Sequences
{
	public class MultiSequence : Sequence
	{

		private readonly Sequence[] sequences;

		public MultiSequence(params Sequence[] sequences)
		{
		}

		protected override void OnException(Exception e)
		{
		}

		protected override IEnumerator Enumerator()
		{
			return null;
		}

		public IEnumerator WaitOne()
		{
			return null;
		}
	}
}
