namespace Falcon.PuzzleCore.Team
{
	public class ScTeamInfo : SCMessage
	{
		public TeamInfo team_info;

		public bool my_team;

		public override string GetEvent()
		{
			return null;
		}

		public override void OnData()
		{
		}
	}
}
