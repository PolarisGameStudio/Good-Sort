namespace Falcon.FalconCore.Scripts.Utils.FActions.Base
{
	public interface IFollowAction : IFAction
	{
	}
	public interface IFollowAction<out T> : IFAction<T>, IFAction, IFollowAction
	{
	}
}
