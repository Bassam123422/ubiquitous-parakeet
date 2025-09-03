using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneController : MonoBehaviour
{
    public Text scoreText;
    public Button homeButton;
    public Button adButton;
    private int score = 0;

    void Start()
    {
        UpdateScore();

        if (homeButton != null)
            homeButton.onClick.AddListener(GoHome);

        if (adButton != null)
            adButton.onClick.AddListener(ShowRewarded);
    }

    void Update()
    {
        // simple score counter
        score += 1;
        UpdateScore();
    }

    void UpdateScore()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }

    void GoHome()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void ShowRewarded()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.ShowRewardedAd();
            GameManager.Instance.AddCoins(100); // reward example
        }
    }
}
