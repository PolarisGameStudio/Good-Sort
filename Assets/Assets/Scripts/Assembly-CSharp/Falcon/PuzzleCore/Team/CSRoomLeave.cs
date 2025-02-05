namespace Falcon.PuzzleCore.Team
{
	public class CSRoomLeave : CSMessage
	{
		public string room_type;

		public string room_id;

		public CSRoomLeave(string room_type, string room_id)
		{
		}

		public override string GetEvent()
		{
			return null;
		}
	}
}
