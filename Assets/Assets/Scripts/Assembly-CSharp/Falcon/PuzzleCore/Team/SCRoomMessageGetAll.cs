using System.Collections.Generic;

namespace Falcon.PuzzleCore.Team
{
	public class SCRoomMessageGetAll : SCMessage
	{
		public string room_type;

		public string room_id;

		public List<RoomMessageInfo> messages;

		public override string GetEvent()
		{
			return null;
		}

		public override void OnData()
		{
		}
	}
}
