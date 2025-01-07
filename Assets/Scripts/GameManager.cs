using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public GameObject btnPlay;
    public GameObject btnReplay;

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

    public void Start()
    {
        Time.timeScale = 0;  // Dừng game
        btnReplay.SetActive(false);
    }

    public void PlayGame()
    {
        Time.timeScale = 1;
        btnPlay.SetActive(false);
    }

    public void GameOver()
    {
        Time.timeScale = 0;  // Dừng game
        btnReplay.SetActive(true);
        ScoreManager.Instance.SaveBestScore();
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }
}
