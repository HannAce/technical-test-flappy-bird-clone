using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{
    //private UIManager m_uiManager;

    public const float ScreenBoundaryX = 14f;
    public bool IsGameOver;
    public bool IsGameStarted;
    
    public static GameManager Instance;

    public Action OnGameStarted;
    public Action OnGameOver;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        //m_uiManager = UIManager.Instance;

        IsGameOver = false;
        Time.timeScale = 0;
    }

    private void OnDestroy()
    {
        Instance = null;
    }

    public void PlayGame()
    {
        Time.timeScale = 1;
        IsGameStarted = true;
        //m_uiManager.DisableStartGameUI();
        OnGameStarted?.Invoke();
    }
    

    public void GameOver()
    {
        Debug.Log("[GameManager] Game Over!");
        IsGameOver = true;
        Time.timeScale = 0;
        // Replaced with event
        //m_uiManager.EnableGameOverUI();
        OnGameOver?.Invoke();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
