namespace Falcon.PuzzleCore.Team
{
	public class SCRoomMessage : SCMessage
	{
		public RoomMessageInfo message;

		public override string GetEvent()
		{
			return null;
		}

		public override void OnData()
		{
		}
	}
}
