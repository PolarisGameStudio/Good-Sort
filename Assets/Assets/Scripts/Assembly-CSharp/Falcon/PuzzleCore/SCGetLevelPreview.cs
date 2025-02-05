namespace Falcon.PuzzleCore
{
	public class SCGetLevelPreview : SCMessage
	{
		public string level_data;

		public override string GetEvent()
		{
			return null;
		}

		public override void OnData()
		{
		}
	}
}
