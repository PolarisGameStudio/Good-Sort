using System;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : Singleton<LevelController>
{
	public class ItemInCell
	{
		public int num;

		public int numItemInLayer2;

		public List<CellType> cellTypes;
	}

	[SerializeField]
	private CellLockController _cellLockController;

	[SerializeField]
	private CellMoveController _cellMoveController;

	[SerializeField]
	private CellDropController _cellDropController;

	[SerializeField]
	private TutorialLevel1 _tutLevel1;

	[SerializeField]
	private HintLevelController _hintLevelController;

	private int _numStuck;

	private int _numTimeOut;

	private int _numAdsTimeoutPerLevel;

	public bool isBuffCombo;

	public bool isX2Star;

	public AnimationCurve curveSwapMove;

	private List<ItemContainer> _itemContainers;

	private List<Cell> _cells;

	private LevelState _levelState;

	private EndGameState _endgameState;

	private float _timePLay;

	private float _timeToPlayRemain;

	private float _timeFreeze;

	private float _timeToPlayInit;

	public Action<int> onIncreaseTime;

	public static List<float> time_active_match3;

	private int lasCheckState;

	private ItemContainer lastItemContainerCheckWin;

	public static Action onStuckInLayer;

	private bool _isWarningTime;

	private int time_to_show_warning;

	private bool _isShowRecommand;

	private int time_to_show_recommand_freeze;

	public Action onShowRecommendFreeze;

	private float _timeCheckWin;

	private bool isEndByManualCheck;

	private const int time_check_win_interval = 1;

	public static Action<int> onMatchItem;

	private bool _isFail;

	public int NumStuck
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int NumTimeOut
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public List<ItemContainer> ItemContainers => null;

	public List<Cell> Cells => null;

	public LevelState LevelState
	{
		get
		{
			return default(LevelState);
		}
		set
		{
		}
	}

	public EndGameState EndGameState
	{
		get
		{
			return default(EndGameState);
		}
		set
		{
		}
	}

	public float TimePLay => 0f;

	public float TimeToPlayRemain
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float TimeFreeze => 0f;

	public float TimeToPlayInit
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public TimeSpan timRemain => default(TimeSpan);

	public bool CanWatchAdToGetMoreTimeEndGame()
	{
		return false;
	}

	protected override void Awake()
	{
	}

	private void OnActiveMatch3(Vector2 vector)
	{
	}

	public void AddTime(int time)
	{
	}

	public void AddTimeFreeze(int time)
	{
	}

	public void InitData(List<Cell> cells, float time, int numLock)
	{
	}

	public void FindItem(ItemType itemType)
	{
	}

	public void CheckState(int state)
	{
	}

	private void CheckWin()
	{
	}

	private bool IsCompleteLevel()
	{
		return false;
	}

	private void CheckStuck()
	{
	}

	public int GetNumSlotBlankInTopRow()
	{
		return 0;
	}

	public bool IsStuckInLayer0()
	{
		return false;
	}

	protected override void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void CheckItemRemain()
	{
	}

	public void EndGame(EndGameState state)
	{
	}

	public float GetRatioItemRemain()
	{
		return 0f;
	}

	public int GetTotalItem()
	{
		return 0;
	}

	public int GetTotalMatch3()
	{
		return 0;
	}

	public int GetNumMatch3Matched()
	{
		return 0;
	}

	public int GetItemMatched()
	{
		return 0;
	}

	private void OnDisable()
	{
	}

	public int GetTotalItemRemain()
	{
		return 0;
	}

	public void Pause()
	{
	}

	public void UnPause()
	{
	}

	public void ResetLayerToStart()
	{
	}

	public int GetStarBonusByTime()
	{
		return 0;
	}

	public bool IsLevelDrop()
	{
		return false;
	}

	public LevelInfo GetLevelInfo()
	{
		return null;
	}

	public void Lose()
	{
	}

	private void LogFail()
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	private List<string> GetQuitDetail()
	{
		return null;
	}

	private void OnApplicationQuit()
	{
	}

	public void AnimEndgame()
	{
	}
}
