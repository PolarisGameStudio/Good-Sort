using System;

namespace Falcon.PuzzleCore.Team
{
	[Serializable]
	public class TeamMemberInfo
	{
		public UserSimpleInfo userInfo;

		public string role;

		public int helps_made;

		public int helps_received;

		public string country_code;

		public bool golden;
	}
}
