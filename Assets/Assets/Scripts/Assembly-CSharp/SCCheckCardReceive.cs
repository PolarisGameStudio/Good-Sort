using System.Collections.Generic;
using Falcon;

public class SCCheckCardReceive : SCMessage
{
	public List<UserInfoSendCard> datas;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
