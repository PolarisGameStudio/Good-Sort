namespace Falcon.PuzzleCore.Team
{
	public class CSRoomMessageGetAll : CSMessage
	{
		public string room_type;

		public string room_id;

		public long last_room_message_update_id;

		public CSRoomMessageGetAll(string room_type, string room_id, long last_room_message_id)
		{
		}

		public override string GetEvent()
		{
			return null;
		}
	}
}
