using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private UIManager m_uiManager;
    
    public static GameManager Instance;

    private void Start()
    {
        Instance = this;
        m_uiManager = UIManager.Instance;
    }

    private void OnDestroy()
    {
        Instance = null;
    }

    public void GameOver()
    {
        // TODO make game over event for other classes to subscribe to?
        m_uiManager.EnableGameOverUI();
        Time.timeScale = 0;
    }
    
}
