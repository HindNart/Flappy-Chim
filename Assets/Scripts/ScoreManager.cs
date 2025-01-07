using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreText;
    private int score = 0;
    private int bestScore = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        bestScore = PlayerPrefs.GetInt("bestScore");
        bestScoreText.text = bestScore.ToString();
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void SaveBestScore()
    {
        if (score > bestScore)
        {
            PlayerPrefs.SetInt("bestScore", score);
        }
    }
}
