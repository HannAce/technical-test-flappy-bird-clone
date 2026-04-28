using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{
    private UIManager m_uiManager;

    public const float ScreenBoundaryX = 14f;
    public bool IsGameOver;
    public bool IsGameStarted;
    
    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        m_uiManager = UIManager.Instance;

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
        m_uiManager.DisableStartGameUI();
    }
    

    public void GameOver()
    {
        Debug.Log("[GameManager] Game Over!");
        // TODO make game over event for other classes to subscribe to?
        m_uiManager.EnableGameOverUI();
        IsGameOver = true;
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
