namespace Falcon.PuzzleCore.Team
{
	public class CSRoomMessageInteract : CSMessage
	{
		public string room_type;

		public string room_id;

		public long room_message_id;

		public string room_message_uuid;

		public string room_message_interact_content;

		public CSRoomMessageInteract(string room_type, string room_id, long room_message_id, string room_message_uuid, string room_message_interact_content)
		{
		}

		public override string GetEvent()
		{
			return null;
		}
	}
}
