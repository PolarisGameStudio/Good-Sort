using System.Collections.Generic;

namespace Falcon.PuzzleCore.Team
{
	public class SCTeamSearch : SCMessage
	{
		public List<TeamInfoSimple> team_infos;

		public override string GetEvent()
		{
			return null;
		}

		public override void OnData()
		{
		}
	}
}
