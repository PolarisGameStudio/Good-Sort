namespace Falcon.FalconCore.Scripts.Utils.FActions.Base
{
	public interface IStartAction : IContinuableAction, IFAction
	{
	}
	public interface IStartAction<out T> : IContinuableAction<T>, IFAction<T>, IFAction, IContinuableAction, IStartAction
	{
		T InvokeAndGet();
	}
}
