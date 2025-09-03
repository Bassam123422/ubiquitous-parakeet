using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button playButton;
    public Button showAdButton;
    public Button rewardedAdButton;

    void Start()
    {
        if (playButton != null)
            playButton.onClick.AddListener(StartGame);

        if (showAdButton != null)
            showAdButton.onClick.AddListener(ShowInterstitial);

        if (rewardedAdButton != null)
            rewardedAdButton.onClick.AddListener(ShowRewarded);
    }

    void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    void ShowInterstitial()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.ShowInterstitialAd();
        }
    }

    void ShowRewarded()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.ShowRewardedAd();
            GameManager.Instance.AddCoins(50); // reward example
        }
    }
}
