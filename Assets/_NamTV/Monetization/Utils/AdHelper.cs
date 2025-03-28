# if USE_ADMOB
using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AdHelper
{
    public static float ScreenRatio
    {
        get
        {
            float screenRatio;
            if (Screen.width > Screen.height)
                screenRatio = Screen.width * 1f / Screen.height;
            else
                screenRatio = Screen.height * 1f / Screen.width;
            return screenRatio;
        }
    }
    public static void SetBannerPos(BannerView _banner, RectanglePosition showPos, Vector2Int offset)
    {
        if (_banner == null) return;

        float screenScale = MobileAds.Utils.GetDeviceScale();
        if (screenScale == 0)
            screenScale = 2.8125f;
        float screenWidth = MobileAds.Utils.GetDeviceSafeWidth();
        if (screenWidth == 0)
            screenWidth = 384;
        float screenHeight;
        if (Screen.width > Screen.height)
            screenHeight = screenWidth / ScreenRatio;
        else
            screenHeight = screenWidth * ScreenRatio;


        float adWidth = (int)(_banner.GetWidthInPixels() / screenScale);
        float adHeight = (int)(_banner.GetHeightInPixels() / screenScale);
        int xMax = (int)(screenWidth - adWidth);
        int yMax = (int)(screenHeight - adHeight);
        int xCenter = (int)(xMax * 0.5f);
        int yCenter = (int)(yMax * 0.5f);

        switch (showPos)
        {
            case RectanglePosition.Center:
                _banner.SetPosition(AdPosition.Center);
                break;
            case RectanglePosition.Top:
                _banner.SetPosition(xCenter + offset.x, offset.y);
                break;
            case RectanglePosition.Bottom:
                _banner.SetPosition(xCenter + offset.x, yMax - offset.y);
                break;
            case RectanglePosition.TopLeft:
                _banner.SetPosition(AdPosition.TopLeft);
                break;
            case RectanglePosition.TopRight:
                _banner.SetPosition(AdPosition.TopRight);
                break;
            case RectanglePosition.BottomLeft:
                _banner.SetPosition(AdPosition.BottomLeft);
                break;
            case RectanglePosition.BottomRight:
                _banner.SetPosition(AdPosition.BottomRight);
                break;
            case RectanglePosition.Left:
                _banner.SetPosition(offset.x, yCenter - offset.y);
                break;
            case RectanglePosition.Right:
                _banner.SetPosition(xMax + offset.x, yCenter - offset.y);
                break;
            default: break;
        }
    }
}
#endif