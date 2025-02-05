using System;

namespace Falcon
{
	[Serializable]
	public abstract class FMessage
	{
		public string _id;

		public long ts;

		public int r;

		public abstract string GetEvent();
	}
}
