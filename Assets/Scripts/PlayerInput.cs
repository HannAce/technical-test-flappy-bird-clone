using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Rigidbody m_rigidbody;
    [SerializeField] private float m_flapForce;

    private GameManager m_gameManager;

    private void Start()
    {
        m_gameManager = GameManager.Instance;
    }

    private void OnFlap()
    {
        if (!m_gameManager.IsGameStarted)
        {
            m_gameManager.PlayGame();
            return;
        }
        
        if (m_gameManager.IsGameOver)
        {
            m_gameManager.RestartGame();
            return;
        }
        
        // Attempted to use AddForce, however the jump height not consistent
        //m_rigidbody.AddForce(0, m_flapForce, 0, ForceMode.VelocityChange);
        m_rigidbody.linearVelocity = new Vector3(0, m_flapForce, 0);
        
    }
}
