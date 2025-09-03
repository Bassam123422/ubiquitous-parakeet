using UnityEngine;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;

public class GameManager : MonoBehaviour, IRewardedVideoAdListener
{
    string appKey = "9a4c0fbb6096be429f2de5a1c20e1cba160429c9698afbd5";

    void Start()
    {
        int adTypes = AppodealAdType.Interstitial | AppodealAdType.Banner | AppodealAdType.RewardedVideo;

        Appodeal.initialize(appKey, adTypes, true);

        Appodeal.setRewardedVideoCallbacks(this);
    }

    public void ShowInterstitial()
    {
        if (Appodeal.isLoaded(AppodealAdType.Interstitial))
        {
            Appodeal.show(AppodealShowStyle.Interstitial);
        }
    }

    public void ShowBanner()
    {
        Appodeal.show(AppodealShowStyle.BannerBottom);
    }

    public void ShowRewardedVideo()
    {
        if (Appodeal.isLoaded(AppodealAdType.RewardedVideo))
        {
            Appodeal.show(AppodealShowStyle.RewardedVideo);
        }
    }

    public void onRewardedVideoLoaded(bool isPrecache) { }
    public void onRewardedVideoFailedToLoad() { }
    public void onRewardedVideoShown() { }
    public void onRewardedVideoFinished(double amount, string name) { }
    public void onRewardedVideoClosed(bool finished) { }
    public void onRewardedVideoExpired() { }
}
