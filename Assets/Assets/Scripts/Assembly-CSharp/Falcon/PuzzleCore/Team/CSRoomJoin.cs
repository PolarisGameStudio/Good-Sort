namespace Falcon.PuzzleCore.Team
{
	public class CSRoomJoin : CSMessage
	{
		public string room_type;

		public string room_id;

		public CSRoomJoin(string room_type, string room_id)
		{
		}

		public override string GetEvent()
		{
			return null;
		}
	}
}
