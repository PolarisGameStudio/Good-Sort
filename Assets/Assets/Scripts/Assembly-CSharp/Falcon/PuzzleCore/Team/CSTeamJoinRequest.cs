namespace Falcon.PuzzleCore.Team
{
	public class CSTeamJoinRequest : CSMessage
	{
		public int team_code;

		public CSTeamJoinRequest(int code)
		{
		}

		public override string GetEvent()
		{
			return null;
		}
	}
}
