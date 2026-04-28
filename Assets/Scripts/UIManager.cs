using System;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject m_GameOverUI;

    public static UIManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        DisableGameOverUI();
    }

    private void OnDestroy()
    {
        Instance = null;
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
