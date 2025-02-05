using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

public class CollectionDataController : NMSingleton<CollectionDataController>
{
	public class CardRecyle
	{
		public int set;

		public int index;

		public int num;
	}

	private const string key = "collection";

	private const string key_new_card = "collection_new_card_";

	public const int level_unlock = 41;

	public const int num_card_per_set = 9;

	public const int num_set = 15;

	private const string ITEM_Type = "collection";

	private CollectionData _collection;

	private CardNewData _cardNews;

	public Action onResetData;

	private long _timeStart;

	private long _timeEnd;

	private int _seasonId;

	private int _badge;

	private static List<int> _badges;

	public List<DataOpenCollectionPack> openCollectionPacks;

	public DataSetComplete setsComplete;

	public const int Max_Star = 5;

	public Action<int> onRecycle;

	private List<UserSimpleInfoWithTeam> _friends;

	public Action<List<UserSimpleInfoWithTeam>> onGetFriends;

	public Action onSendCardToFriend;

	public Action<(List<UserInfoSendCard> dataUsers, List<CardData> dataCards)> onReceiveCardFromFriend;

	public int badge => 0;

	public CollectionData Collection => null;

	public List<UserSimpleInfoWithTeam> GetFriends => null;

	public ObscuredInt NumSendPerDay => default(ObscuredInt);

	protected override void Init()
	{
	}

	public void SetDataToDefault()
	{
	}

	private void OnCompleteLevel()
	{
	}

	public void CheckAndInitDataWhenUnLockFeature()
	{
	}

	public void ResetData()
	{
	}

	private void SaveNewCard()
	{
	}

	private void Save()
	{
	}

	public bool IsUnlock()
	{
		return false;
	}

	public bool IsActive()
	{
		return false;
	}

	public bool CanGetReward()
	{
		return false;
	}

	public TimeSpan GetTimeSpanEndSession()
	{
		return default(TimeSpan);
	}

	private void UpdateTimeFromRemoteConfig()
	{
	}

	public void CheckTimeResetNumSendCard()
	{
	}

	public TimeSpan GetNextTimeResetNumSend()
	{
		return default(TimeSpan);
	}

	public DateTime GetTimeStart()
	{
		return default(DateTime);
	}

	public DateTime GetTimeEnd()
	{
		return default(DateTime);
	}

	public (bool, List<ResourceValue>, bool, int) CheckEndSeason()
	{
		return default((bool, List<ResourceValue>, bool, int));
	}

	public bool IsShowTut()
	{
		return false;
	}

	public void ShowTut()
	{
	}

	public void UpdateDataFromServer(CollectionDataServer collectionData)
	{
	}

	public void ShowNewCard()
	{
	}

	public bool IsNewCard(int set, int index)
	{
		return false;
	}

	public int GetNumNewCardInSet(int set)
	{
		return 0;
	}

	public void OpenSet(int set)
	{
	}

	public int GetTotalCard()
	{
		return 0;
	}

	public int GetNumCardOwn()
	{
		return 0;
	}

	public void OpenPack(CollectionPack pack, int num)
	{
	}

	public void OpenPackForTut()
	{
	}

	private List<CardData> OpenPack(CollectionPack pack)
	{
		return null;
	}

	public void ShowOpenPackDone(CollectionPack pack)
	{
	}

	public void ShowSetNewDone()
	{
	}

	public bool IsContainCard(int set, int index)
	{
		return false;
	}

	private CardData GetRandomCardData(int star)
	{
		return null;
	}

	private void AddCard(CardData cardData)
	{
	}

	public int GetNumCardBySet(int set)
	{
		return 0;
	}

	public ResourceValue GetResourceValueWhenCollectFullSet(int set)
	{
		return null;
	}

	public bool IsFullSet(int set)
	{
		return false;
	}

	public bool CanClaimSet(int set)
	{
		return false;
	}

	public void CheckAndClaimSet()
	{
	}

	public void ClaimSet(int set)
	{
	}

	public List<ResourceValue> GetResourceValueWhenCollectFullAllSet()
	{
		return null;
	}

	public bool IsFullAllSet()
	{
		return false;
	}

	public bool CanClaimWhenFulAllSet()
	{
		return false;
	}

	public void ClaimWhenFulAllSet()
	{
	}

	public int GetCardStar(int set, int index)
	{
		return 0;
	}

	public bool IsGoldenFrame(int set, int index)
	{
		return false;
	}

	public int GetCurrentStar()
	{
		return 0;
	}

	public int GetStarRequireToRecycle(int index)
	{
		return 0;
	}

	public List<ResourceValue> GetResourceWhenRecycle(int index)
	{
		return null;
	}

	public bool CanRecycle(int index)
	{
		return false;
	}

	public void Recycle(int index)
	{
	}

	public Dictionary<int, List<CardRecyle>> GetDataCardRecycle()
	{
		return null;
	}

	private int GetStarConverFromCard()
	{
		return 0;
	}

	public void GetListFriend()
	{
	}

	private void OnGetFriends(List<UserSimpleInfoWithTeam> friends)
	{
	}

	public bool CanSendCardToFriend(int set, int index)
	{
		return false;
	}

	public (bool, bool, bool, bool) StateCanSendCardToFriend(int set, int index)
	{
		return default((bool, bool, bool, bool));
	}

	public void SendCardToFriend(int set, int index, int codeReceive)
	{
	}

	public void CheckReceiveCard()
	{
	}

	public void CheckReceiveCardFromServer(SCCheckCardReceive sCCheckCardReceive)
	{
	}

	public (int, int) GetLimitSend()
	{
		return default((int, int));
	}

	public TimeSpan GetTimerLimitDaily()
	{
		return default(TimeSpan);
	}
}
