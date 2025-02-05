namespace Falcon.FalconCore.Scripts.Utils.FActions.Base
{
	public interface IChainAction : IContinuableAction, IFAction, IFollowAction
	{
	}
	public interface IChainAction<T> : IContinuableAction<T>, IFAction<T>, IFAction, IContinuableAction, IChainAction, IFollowAction, IFollowAction<T>
	{
		bool TryInvoke(out T result);
	}
}
