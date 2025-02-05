namespace Falcon.PuzzleCore.Team
{
	public class CSSetCoLeader : CSMessage
	{
		public int member_code;

		public CSSetCoLeader(int member_code)
		{
		}

		public override string GetEvent()
		{
			return null;
		}
	}
}
