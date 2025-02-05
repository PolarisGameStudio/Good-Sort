namespace Falcon.PuzzleCore.Team
{
	public class CSTeamJoinResponse : CSMessage
	{
		public long messageId;

		public bool accept;

		public CSTeamJoinResponse(long messageId, bool accept)
		{
		}

		public override string GetEvent()
		{
			return null;
		}
	}
}
