namespace Falcon.PuzzleCore.Team
{
	public class CSGetRoomMessages : CSMessage
	{
		public string room_type;

		public string room_id;

		public int page;

		public CSGetRoomMessages(string room_type, string room_id, int page)
		{
		}

		public override string GetEvent()
		{
			return null;
		}
	}
}
