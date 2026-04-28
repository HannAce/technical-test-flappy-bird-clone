using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private UIManager m_uiManager;

    public const float screenBoundaryX = 14f;
    public bool isGameOver;
    
    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        m_uiManager = UIManager.Instance;

        isGameOver = false;
        Time.timeScale = 1;
    }

    private void OnDestroy()
    {
        Instance = null;
    }

    public void PlayGame()
    {
        Time.timeScale = 1;
    }
    

    public void GameOver()
    {
        Debug.Log("[GameManager] Game Over!");
        // TODO make game over event for other classes to subscribe to?
        m_uiManager.EnableGameOverUI();
        isGameOver = true;
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
