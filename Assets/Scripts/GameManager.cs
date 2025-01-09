using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    // public GameObject touchToPlay;
    // public GameObject btnReplay;
    // public GameObject btnOption;
    // public GameObject btnSetting;
    // public GameObject settingBox;

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
        UIController.Instance.btnReplay.SetActive(false);
    }

    public void PlayGame()
    {
        Time.timeScale = 1;
        UIController.Instance.HideUI();
    }

    public void GameOver()
    {
        Time.timeScale = 0;  // Dừng game
        UIController.Instance.btnReplay.SetActive(true);
        AudioManager.Instance.PlayHitSound();
        ScoreManager.Instance.SaveBestScore();
    }

    public void RestartGame()
    {
        Time.timeScale = 1; //Tiếp tục
        SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
