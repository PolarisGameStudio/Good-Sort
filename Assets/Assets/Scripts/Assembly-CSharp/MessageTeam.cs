using System;
using System.Collections.Generic;

[Serializable]
public class MessageTeam
{
	public int messageId;

	public int messageType;

	public UserSimpleInfo sender;

	public string content;

	public List<int> donaters;

	public long createdDate;

	public string extData;

	public MessageTeamType GetMessageTeamType()
	{
		return default(MessageTeamType);
	}

	public T GetDataExtend<T>() where T : class
	{
		return null;
	}

	public string GetTimeSpan()
	{
		return null;
	}

	public bool IsValidMessage()
	{
		return false;
	}
}
