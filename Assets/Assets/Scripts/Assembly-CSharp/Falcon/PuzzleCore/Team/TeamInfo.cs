using System;

namespace Falcon.PuzzleCore.Team
{
	[Serializable]
	public class TeamInfo
	{
		public int code;

		public int owner_code;

		public int avatar_id;

		public string name;

		public string description;

		public int num_member;

		public int max_member;

		public int score;

		public int weekly_helps;

		public int required_levels;

		public TeamMemberInfo[] member_infos;

		public bool open;

		public bool requested;

		public int team_class;

		public long nextRequestHeart;

		public int activityLevel;
	}
}
