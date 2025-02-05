using System;

namespace Falcon.FalconCore.Scripts.Utils.FActions.Base
{
	public interface IFAction
	{
		Exception Exception { get; }

		bool Done { get; }

		void Schedule();

		void Cancel();

		void Invoke();

		bool CanInvoke();
	}
	public interface IFAction<out T> : IFAction
	{
		T Result { get; }
	}
}
