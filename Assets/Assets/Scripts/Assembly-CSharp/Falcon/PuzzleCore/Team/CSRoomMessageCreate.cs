namespace Falcon.PuzzleCore.Team
{
	public class CSRoomMessageCreate : CSMessage
	{
		public string room_type;

		public string room_id;

		public string room_message_type;

		public string room_message_content;

		public CSRoomMessageCreate(string room_type, string room_id, string room_message_type, string room_message_content)
		{
		}

		public override string GetEvent()
		{
			return null;
		}
	}
}
