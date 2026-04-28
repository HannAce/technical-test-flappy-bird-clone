using System;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject m_startGameUI;
    [SerializeField] private GameObject m_GameOverUI;

    public static UIManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        EnableStartGameUI();
        DisableGameOverUI();
    }

    private void OnDestroy()
    {
        Instance = null;
    }

    private void EnableStartGameUI()
    {
        m_startGameUI.SetActive(true);
    }
    
    public void DisableStartGameUI()
    {
        m_startGameUI.SetActive(false);
    }
    
    public void EnableGameOverUI()
    {
        m_GameOverUI.SetActive(true);
    }

    private void DisableGameOverUI()
    {
        m_GameOverUI.SetActive(false);
    }
}
