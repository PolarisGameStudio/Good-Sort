using System;

public interface IBindData
{
	void RequestSignIn(Action<DataBinding> onSuccess, Action onFail);

	void SignOut(Action onSuccess);
}
