using System;
using System.Collections.Generic;

public class FriendDataController : NMSingleton<FriendDataController>
{
	public Action onGetFriend;

	private List<UserSimpleInfoWithTeam> _friends;

	private List<UserSimpleInfoWithTeam> _friendPending;

	private bool _isGetFriend;

	public Action onGetSuggest;

	public List<UserSimpleInfoWithTeam> friendsSuggested;

	public Action onRemoveFriend;

	public Action onResponRequest;

	public List<UserInfoSearch> friendSearchs;

	public Action<List<UserInfoSearch>> onSearchFriend;

	public Action onSendFriendRequest;

	public List<UserSimpleInfoWithTeam> friends => null;

	public List<UserSimpleInfoWithTeam> friendPending => null;

	protected override void Init()
	{
	}

	private void OnSignOut()
	{
	}

	private void OnSignIn(BindDataType type)
	{
	}

	private void ClearCacheFriendAndPending()
	{
	}

	private void ChangeScene(SceneState sceneState)
	{
	}

	private void ClearCache()
	{
	}

	public void GetFriendInfos()
	{
	}

	public void GetFriendInfosFromServer(SCGetFriendInfos sCGetFriendInfos)
	{
	}

	public void GetSuggestFriends()
	{
	}

	public void GetSuggestFriendsFromServer(SCSuggestFriends sCSuggestFriends)
	{
	}

	public void RemoveFriend(int code)
	{
	}

	public void ResponRequest(int code, bool accept)
	{
	}

	public void SearchUser(string search)
	{
	}

	public void SearchUserFromServer(SCSearchUser sCSearchUser)
	{
	}

	private UserSimpleInfoWithTeam RemoveData(int code, List<UserSimpleInfoWithTeam> datas)
	{
		return null;
	}

	public void DismissSuggest(int code)
	{
	}

	public void SendFriendRequest(int code)
	{
	}

	public void SendFriendRequest(UserInfoDetail data)
	{
	}

	public void AddFriendFacebook(string fbId)
	{
	}

	public void ShareGame()
	{
	}
}
