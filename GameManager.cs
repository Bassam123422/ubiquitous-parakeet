using UnityEngine;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;

public class GameManager : MonoBehaviour, IInterstitialAdListener, IRewardedVideoAdListener
{
    private string appKey = "9a4c0fbb6096be429f2de5a1c20e1cba160429c9698afbd5";

    void Start()
    {
        int adTypes = Appodeal.INTERSTITIAL | Appodeal.REWARDED_VIDEO;
        Appodeal.initialize(appKey, adTypes, true);

        Appodeal.setInterstitialCallbacks(this);
        Appodeal.setRewardedVideoCallbacks(this);
    }

    public void ShowAdOnGameOver()
    {
        if (Appodeal.isLoaded(Appodeal.INTERSTITIAL))
        {
            Appodeal.show(Appodeal.INTERSTITIAL);
        }
    }

    public void ShowRewardedAd()
    {
        if (Appodeal.isLoaded(Appodeal.REWARDED_VIDEO))
        {
            Appodeal.show(Appodeal.REWARDED_VIDEO);
        }
    }

    // Interstitial callbacks
    public void onInterstitialLoaded(bool isPrecache) { }
    public void onInterstitialFailedToLoad() { }
    public void onInterstitialShown() { }
    public void onInterstitialShowFailed() { }
    public void onInterstitialClicked() { }
    public void onInterstitialClosed() { }
    public void onInterstitialExpired() { }

    // Rewarded video callbacks
    public void onRewardedVideoLoaded(bool precache) { }
    public void onRewardedVideoFailedToLoad() { }
    public void onRewardedVideoShown() { }
    public void onRewardedVideoShowFailed() { }
    public void onRewardedVideoFinished(double amount, string name)
    {
        Debug.Log("Reward granted: " + amount + " " + name);
    }
    public void onRewardedVideoClosed(bool finished) { }
    public void onRewardedVideoExpired() { }
    public void onRewardedVideoClicked() { }
}
