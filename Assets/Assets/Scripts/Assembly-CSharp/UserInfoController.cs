using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UserInfoController : NMSingleton<UserInfoController>
{

	public const int num_avatar = 18;

	private const string key = "user_info_n";

	private const string key_change_name = "change_name";

	public List<int> badges;

	public int frame_master_pass;

	public List<int> frame_star_collabs;

	public List<int> frame_diggings;

	public int frame_single_day;

	public List<int> frame_food_duel;

	public List<int> frame_magic_cauldron;

	public List<int> frame_stall_bulding;

	public const int num_frame = 11;

	public List<int> frames;

	private UserProfile _userInfo;

	private int _changeName;

	private Action<UserInfoDetail> _onGetUserInfoDetail;

	private int _currentCode;

	private UserInfoDetail _userInfoDetail;

	private Coroutine _coroutineGetInfo;

	public UserProfile UserInfo => null;

	public UserSimpleInfo UserSimpleInfo => null;

	public int ChangeName => 0;

	protected override void Init()
	{
	}

	public bool IsGoldenFrame()
	{
		return false;
	}

	public void CheckFrameMasterPass()
	{
	}

	private void InitData()
	{
	}

	public void SetDataToDefault()
	{
	}

	public bool NeedShowChangeName()
	{
		return false;
	}

	public void ShowChangeNameDone()
	{
	}

	public void SetName(string name)
	{
	}

	public void SetAvatar(int id)
	{
	}

	public void SetAvatar(int id, string url)
	{
	}

	public void SetUrl(string url)
	{
	}

	public void SetFrame(int frame)
	{
	}

	public void SetBadge(int badge)
	{
	}

	private void SaveChangeName()
	{
	}

	private void Save()
	{
	}

	public bool HasSpecialAvatar()
	{
		return false;
	}

	public void UpdateDataFromServer(UserProfile userInfo, int changeName)
	{
	}

	public UserInfoDetail GetMyUserInfoDetail()
	{
		return null;
	}

	public void GetUserinfoDetail(int code, Action<UserInfoDetail> callBack)
	{
	}

	private IEnumerator GetInfoTimeout()
	{
		return null;
	}

	public void GetUserinfoDetailFromServer(UserInfoDetail userInfo)
	{
	}

	public bool IsUnlockBage(int id)
	{
		return false;
	}

	public void SelectBages(int id)
	{
	}

	public bool IsUnlockFrame(int id)
	{
		return false;
	}

	public bool IsFrameMasterPass(int id)
	{
		return false;
	}

	public bool IsFrameScoopSquad(int id)
	{
		return false;
	}

	public bool IsFrameDigging(int id)
	{
		return false;
	}

	public bool IsFrameSingleDay(int id)
	{
		return false;
	}

	public bool IsFrameFoodDuel(int id)
	{
		return false;
	}

	public bool IsFrameMagicCauldron(int id)
	{
		return false;
	}

	public bool IsFrameStallBuilding(int id)
	{
		return false;
	}
}
