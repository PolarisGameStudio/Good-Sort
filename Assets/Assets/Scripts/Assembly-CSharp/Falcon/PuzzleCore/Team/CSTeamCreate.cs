namespace Falcon.PuzzleCore.Team
{
	public class CSTeamCreate : CSMessage
	{
		public int avatar_id;

		public string name;

		public string description;

		public bool open;

		public int required_level;

		public CSTeamCreate(int logo, string teamName, string description, bool open, int requiredLevel)
		{
		}

		public override string GetEvent()
		{
			return null;
		}
	}
}
