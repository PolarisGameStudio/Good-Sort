namespace Falcon.PuzzleCore.Team
{
	public class SCUserBasicInfo : SCMessage
	{
		public UserBasicInfo userInfo;

		public override string GetEvent()
		{
			return null;
		}

		public override void OnData()
		{
		}
	}
}
