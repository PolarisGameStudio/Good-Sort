using System;

namespace Falcon
{
	[Serializable]
	public abstract class SCMessage : FMessage
	{
		public abstract void OnData();
	}
}
