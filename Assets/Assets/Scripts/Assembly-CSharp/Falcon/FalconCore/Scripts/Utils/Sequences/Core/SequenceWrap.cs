using System;
using System.Collections;
using System.Collections.Generic;

namespace Falcon.FalconCore.Scripts.Utils.Sequences.Core
{
	public class SequenceWrap : SeqWrap<object>
	{
		public SequenceWrap(IEnumerator enumerator, Action<Exception> ifDropOut = null)
			: base((IEnumerator<object>)null, (Action<Exception>)null)
		{
		}
	}
}
