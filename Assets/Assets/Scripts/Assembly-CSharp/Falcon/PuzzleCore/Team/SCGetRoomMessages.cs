using System.Collections.Generic;

namespace Falcon.PuzzleCore.Team
{
	public class SCGetRoomMessages : SCMessage
	{
		public string room_type;

		public string room_id;

		public List<RoomMessageInfo> messages;

		public int page;

		public int total_pages;

		public override string GetEvent()
		{
			return null;
		}

		public override void OnData()
		{
		}
	}
}
