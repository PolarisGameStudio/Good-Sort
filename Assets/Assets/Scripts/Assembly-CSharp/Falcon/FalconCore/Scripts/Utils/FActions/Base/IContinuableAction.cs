namespace Falcon.FalconCore.Scripts.Utils.FActions.Base
{
	public interface IContinuableAction : IFAction
	{
	}
	public interface IContinuableAction<out T> : IFAction<T>, IFAction, IContinuableAction
	{
	}
}
