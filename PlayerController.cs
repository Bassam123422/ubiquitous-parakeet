using UnityEngine;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Initialize Appodeal
        string appKey = "9a4c0fbb6096be429f2de5a1c20e1cba160429c9698afbd5";
        Appodeal.initialize(appKey, Appodeal.INTERSTITIAL | Appodeal.REWARDED_VIDEO);

        Debug.Log("Appodeal Initialized with App Key: " + appKey);
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShowRewardedAd();
        }
    }

    void ShowRewardedAd()
    {
        if (Appodeal.isLoaded(Appodeal.REWARDED_VIDEO))
        {
            Appodeal.show(Appodeal.REWARDED_VIDEO);
        }
        else
        {
            Debug.Log("Rewarded video not loaded yet.");
        }
    }
}
