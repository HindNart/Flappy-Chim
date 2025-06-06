using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public bool isPlaying = false;
    public float gravity = 0;

    private void Awake()
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

    public void PlayGame()
    {
        isPlaying = true;
        gravity = 1.5f;
        UIManager.Instance.HideUI();
    }

    public void GameOver()
    {
        Time.timeScale = 0;  // Dừng game
        UIManager.Instance.btnReplay.SetActive(true);
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