namespace Falcon.PuzzleCore.Team
{
	public class CSTeamRemoveMember : CSMessage
	{
		public int member_code;

		public CSTeamRemoveMember(int member_code)
		{
		}

		public override string GetEvent()
		{
			return null;
		}
	}
}
