using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject m_startGameUI;
    [SerializeField] private GameObject m_GameOverUI;

    private GameManager m_gameManager;
    
    // No longer need singleton since using events
    //public static UIManager Instance;

    private void Awake()
    {
        //Instance = this;
    }

    private void Start()
    {
        m_gameManager = GameManager.Instance;
        m_gameManager.OnGameStarted += DisableStartGameUI;
        m_gameManager.OnGameOver += EnableGameOverUI;
        
        EnableStartGameUI();
        DisableGameOverUI();
    }

    private void OnDestroy()
    {
        //Instance = null;

        if (m_gameManager != null)
        {
            m_gameManager.OnGameStarted -= DisableStartGameUI;
            m_gameManager.OnGameOver -= EnableGameOverUI;
        }
    }

    private void EnableStartGameUI()
    {
        m_startGameUI.SetActive(true);
    }
    
    private void DisableStartGameUI()
    {
        m_startGameUI.SetActive(false);
    }
    
    private void EnableGameOverUI()
    {
        m_GameOverUI.SetActive(true);
    }

    private void DisableGameOverUI()
    {
        m_GameOverUI.SetActive(false);
    }
}
