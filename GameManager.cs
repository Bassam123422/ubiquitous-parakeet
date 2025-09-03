using UnityEngine;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int playerCoins = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Debug.Log("Game Manager started.");
    }

    public void AddCoins(int amount)
    {
        playerCoins += amount;
        Debug.Log("Coins: " + playerCoins);
    }

    public void ShowInterstitialAd()
    {
        if (Appodeal.isLoaded(Appodeal.INTERSTITIAL))
        {
            Appodeal.show(Appodeal.INTERSTITIAL);
        }
        else
        {
            Debug.Log("Interstitial Ad not loaded yet.");
        }
    }

    public void ShowRewardedAd()
    {
        if (Appodeal.isLoaded(Appodeal.REWARDED_VIDEO))
        {
            Appodeal.show(Appodeal.REWARDED_VIDEO);
        }
        else
        {
            Debug.Log("Rewarded Ad not loaded yet.");
        }
    }
}
