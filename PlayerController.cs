using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int health = 3;
    public int score = 0;

    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if (health <= 0)
        {
            OnPlayerLose();
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            OnPlayerLose();
        }
    }

    void OnPlayerLose()
    {
        if (gameManager != null)
        {
            gameManager.ShowAdOnGameOver();
        }
        ResetGame();
    }

    public void AddScore(int points)
    {
        score += points;
    }

    public void RequestReward()
    {
        if (gameManager != null)
        {
            gameManager.ShowRewardedAd();
        }
    }

    void ResetGame()
    {
        health = 3;
        score = 0;
    }
}
