namespace Falcon.FalconCore.Scripts.Utils.Sequences.Core
{
	public class SequenceCancelException : SequenceException
	{
		public SequenceCancelException(string message)
			: base(null)
		{
		}

		public SequenceCancelException()
			: base(null)
		{
		}
	}
}
