namespace Falcon.PuzzleCore.Team
{
	public class CSTeamSearch : CSMessage
	{
		public string team_name;

		public CSTeamSearch(string name)
		{
		}

		public override string GetEvent()
		{
			return null;
		}
	}
}
