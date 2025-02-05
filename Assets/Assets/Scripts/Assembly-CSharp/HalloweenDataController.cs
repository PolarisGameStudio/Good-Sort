using System;
using System.Collections.Generic;

public class HalloweenDataController : NMSingleton<HalloweenDataController>
{
	public const int frame_id = -3;

	public const int max_level = 14;

	private const string key = "hlw_dig";

	public const int level_unlock = 20;

	private HalloweenData _halloweenData;

	private long _timeStart;

	private long _timeEnd;

	private int _shovelFromLevel;

	private BoardUtils _boardUtils;

	public Action OnCheckAndGenHiddenLevel;

	public Action<(int x, int y, int indexCellBoardType, ResourceValue resource, ItemInBoard itemInBoard, bool nextLevel)> OnDigging;

	public const string ItemType = "halloween";

	public HalloweenData HalloweenData => null;

	public int ShovelFromLevel => 0;

	protected override void Init()
	{
	}

	public DateTime GetTimeStart()
	{
		return default(DateTime);
	}

	public DateTime GetTimeEnd()
	{
		return default(DateTime);
	}

	private void UpdateTimeFromRemoteConfig()
	{
	}

	private void OnCompleteLevel()
	{
	}

	public void BuyPack()
	{
	}

	public void ConfirmUpdateShovelReceiveFromLevel()
	{
	}

	private void OnChangeScene(SceneState state)
	{
	}

	private void InitData()
	{
	}

	public void SetDataToDefault()
	{
	}

	private void Save()
	{
	}

	public void AddShove(int amount)
	{
	}

	public bool IsActiving()
	{
		return false;
	}

	private void CheckAndInitBoard()
	{
	}

	private void CheckAndGenItemHiden()
	{
	}

	public bool IsPassAllLevel()
	{
		return false;
	}

	private void NextLevel()
	{
	}

	public bool CanDig(int row, int col)
	{
		return false;
	}

	public void Digging(int row, int col)
	{
	}

	private bool IsDiggingFullItem(ItemInBoard itemInBoard)
	{
		return false;
	}

	private bool IsPosContainItem(int row, int col)
	{
		return false;
	}

	private ResourceValue GetRandomResourceWhenDiggingEmptyCell()
	{
		return null;
	}

	public List<int> GetItemsRequire(int level)
	{
		return null;
	}

	public (ChestType?, List<ResourceValue>) GetResourceByLevel(int level)
	{
		return default((ChestType?, List<ResourceValue>));
	}

	public List<ResourceValue> GetGrandResource()
	{
		return null;
	}

	public bool CanClaimGrandResource()
	{
		return false;
	}

	public void ClaimResource(int level)
	{
	}

	public bool IsX2ShovelResource()
	{
		return false;
	}

	public RewardState GetRewardState(int level)
	{
		return default(RewardState);
	}

	public void UpdateDataFromServer(HalloweenDataServer halloweenData)
	{
	}

	public List<int> GetItemRequire()
	{
		return null;
	}

	public List<int> GetItemRequireSort()
	{
		return null;
	}

	public TimeSpan GetTimeRemaining()
	{
		return default(TimeSpan);
	}

	public bool IsUnLock()
	{
		return false;
	}

	public bool IsShowTut()
	{
		return false;
	}

	public void ConfirmTut()
	{
	}

	public void ConfirmEnd()
	{
	}

	public bool IsEnd()
	{
		return false;
	}

	public HalloweenState GetState()
	{
		return default(HalloweenState);
	}

	public int GetNumItemAppearBefore(int itemId)
	{
		return 0;
	}

	public void ResetData()
	{
	}
}
