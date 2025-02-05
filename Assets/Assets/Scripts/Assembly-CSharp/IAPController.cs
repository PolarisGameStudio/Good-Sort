using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Security;

public class IAPController : PersistentSingleton<IAPController>, IDetailedStoreListener, IStoreListener
{
	
	[SerializeField]
	private UnityGameServicesInit _unityGameServices;

	private bool _isRestore;

	private Action<string> _purchaseSuccess;

	private Action _purchaseFail;

	private IStoreController m_StoreController;

	private IExtensionProvider m_StoreExtensionProvider;

	private static IAppleExtensions sAppleExtensions;

	public Action InitializeSucceeded;

	private bool isPurchasing;

	private Coroutine _coroutinePurchaseComplete;

	private PurchaseEventArgs _cachePurchaseEvent;

	private IPurchaseReceipt[] _cachePurchaseReceipts;

	public static Action OnStartPurchase;

	public static Action OnPurchaseFail;

	public static Action<string> OnPurchaseSuccess;

	private void Start()
	{
	}

	public void InitializePurchasing()
	{
	}

	public bool IsInitialized()
	{
		return false;
	}

	public void OnInitializeFailed(InitializationFailureReason error)
	{
	}

	void IStoreListener.OnInitializeFailed(InitializationFailureReason error, string message)
	{
	}

	private bool ValidateReceipt(string receipt, out IPurchaseReceipt[] purchaseReceipts)
	{
		purchaseReceipts = null;
		return false;
	}

	public AppleInAppPurchaseReceipt GetAppleIAPReceipt(string productId, IPurchaseReceipt[] purchaseReceipts)
	{
		return null;
	}

	public GooglePlayReceipt GetGooglePlayReceipt(string productId, IPurchaseReceipt[] purchaseReceipts)
	{
		return null;
	}

	private IPurchaseReceipt GetPurchaseReceipt(string productId, IPurchaseReceipt[] purchaseReceipts)
	{
		return null;
	}

	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs purchaseEvent)
	{
		return default(PurchaseProcessingResult);
	}

	private IEnumerator DelayCallOnPurchaseComplete(PurchaseEventArgs purchaseEvent, IPurchaseReceipt[] purchaseReceipts)
	{
		return null;
	}

	private void HandleWhenPurchaseSuccess(string productID, GooglePlayReceipt googleReceipt = null, AppleInAppPurchaseReceipt appleReceipt = null, string payload = "", bool isSubscription = false)
	{
	}

	private void OnPurchaseCompleted(PurchaseEventArgs args, IPurchaseReceipt[] purchaseReceipts)
	{
	}

	private void ReadReceipt(PurchaseEventArgs args, string payload, IPurchaseReceipt[] purchaseReceipts)
	{
	}

	public void ValidatePurchase(bool isValidate, string token)
	{
	}

	public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
	{
	}

	void IDetailedStoreListener.OnPurchaseFailed(Product product, PurchaseFailureDescription failureDescription)
	{
	}

	public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
	{
	}

	public void Restore(Action<string> callBack)
	{
	}

	public void Purchase(string productID, Action<string> callBackSuccess = null, Action callBackFailed = null)
	{
	}

	public string GetPrice(string productID)
	{
		return null;
	}

	public ProductMetadata GetProductMetadata(string productID)
	{
		return null;
	}

	public SubscriptionInfo GetSubscriptionInfo(string productID)
	{
		return null;
	}

	private void LogAF(string id)
	{
	}
}
