using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Falcon.FalconCore.Scripts.Utils.Sequences.Core;

namespace Falcon.FalconCore.Scripts.Utils.Sequences.Entity
{
	public class WaitForFrame : Sequence
	{

		private readonly int frames;

		public WaitForFrame(int frames)
		{
		}

		protected override IEnumerator Enumerator()
		{
			return null;
		}
	}
}
