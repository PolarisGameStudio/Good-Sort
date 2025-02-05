using System;
using System.Collections.Generic;

public class BindDataController : NMSingleton<BindDataController>
{
	private Dictionary<string, IBindData> _dicBindDataByName;

	private Dictionary<BindDataType, IBindData> _dicBindData;

	public Action<BindDataType> onSignIn;

	public Action<BindDataType> onSignInFail;

	public Action onSignOut;

	protected override void Init()
	{
	}

	public void SignIn(BindDataType bindDataType)
	{
	}

	public void CancelBindData()
	{
	}

	public void CancelBindDataFromSerer(SCCancelBindData sCCancelBindData)
	{
	}

	public BindDataState GetBindDataState()
	{
		return default(BindDataState);
	}
}
