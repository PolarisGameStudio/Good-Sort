namespace Falcon.PuzzleCore.Team
{
	public class CsTeamInfo : CSMessage
	{
		public int team_code;

		public CsTeamInfo(int code)
		{
		}

		public override string GetEvent()
		{
			return null;
		}
	}
}
