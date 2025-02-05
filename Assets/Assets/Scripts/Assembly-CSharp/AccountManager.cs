using Falcon.PuzzleCore.UserData;

public class AccountManager : NMSingleton<AccountManager>
{
	private const string key_sequence = "sequence";

	private int _sequence;

	private const string key_account_info = "account_info";

	private AccountInfo _accountInfo;

	private AccountData _accountData;

	private const string key_hack_suspicion = "check_hack";

	private bool _hackSuspicion;

	private string _appsflyerId;

	private const string key_firebase = "firebase_data";

	private FirebaseData _firebaseData;

	private const string key_appsflyer = "appsflyer_data";

	private AppsFlyerData _appsFlyerData;

	public int Sequence
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public AccountInfo AccountInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AccountData AccountData => null;

	public string Google_id
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string FB_id
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string Apple_id
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool DataBinded
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public int Code => 0;

	public string CodeString => null;

	public bool HackSuspicion
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string AppsflyerId => null;

	private void SaveSequence()
	{
	}

	public void SaveAccountInfo()
	{
	}

	public void OnBindData(string bind_type, string bind_id, string bind_data)
	{
	}

	public void OnFbLogin(string id)
	{
	}

	public void OnGoogleLogin(string id)
	{
	}

	public void OnAppleLogin(string id)
	{
	}

	private void RestartNetManagerWhenInited()
	{
	}

	protected override void Init()
	{
	}

	private void SaveFirebasData()
	{
	}

	private void CheckToUpdateFirebaseData()
	{
	}

	private void SaveAppsflyer()
	{
	}

	private void CheckAndUpdateAppsflyer()
	{
	}

	public void CheckToUpdateAppsflyer()
	{
	}

	private ThirdPartyData GetThirdPartyData()
	{
		return null;
	}

	private string GetAdvertisingID()
	{
		return null;
	}

	private DeviceInfo GetDeviceInfo()
	{
		return null;
	}

	public int GetVerInt()
	{
		return 0;
	}

	public ApkInfo GetApkInfo()
	{
		return null;
	}

	private string CalculateMD5(string s)
	{
		return null;
	}

	private string CalculateMD5FromFile(string filename)
	{
		return null;
	}

	private string DeviceUniqueIdentifier()
	{
		return null;
	}

	private string GenerateUserName()
	{
		return null;
	}

	private string CreateUniqueString()
	{
		return null;
	}
}
