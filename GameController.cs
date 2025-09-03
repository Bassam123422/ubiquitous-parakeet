using UnityEngine;
using AppodealStack.Monetization.Api;
using AppodealStack.Monetization.Common;

public class GameController : MonoBehaviour
{
    private const string appKey = "9a4c0fbb6096be429f2de5a1c20e1cba160429c9698afbd5";

    void Start()
    {
        // Initialize Appodeal with Interstitial ads
        int adTypes = AppodealAdType.Interstitial;
        Appodeal.Initialize(appKey, adTypes, true);
    }

    public void ShowAd()
    {
        if (Appodeal.IsLoaded(AppodealAdType.Interstitial))
        {
            Appodeal.Show(AppodealShowStyle.Interstitial);
        }
        else
        {
            Debug.Log("Interstitial not loaded yet");
        }
    }
}
