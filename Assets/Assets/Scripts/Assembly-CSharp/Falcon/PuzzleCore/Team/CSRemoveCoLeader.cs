namespace Falcon.PuzzleCore.Team
{
	public class CSRemoveCoLeader : CSMessage
	{
		public int member_code;

		public CSRemoveCoLeader(int member_code)
		{
		}

		public override string GetEvent()
		{
			return null;
		}
	}
}
