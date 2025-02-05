namespace Falcon.FalconCore.Scripts.Utils.FActions.Base
{
	public abstract class StartAction : FAction, IStartAction, IContinuableAction, IFAction
	{
		public override bool CanInvoke()
		{
			return false;
		}
	}
}
