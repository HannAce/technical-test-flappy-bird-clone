using System;
using UnityEngine;

public class PlayerCollisionDetector : MonoBehaviour
{
    private ScoreManager m_scoreManager;
    private GameManager m_gameManager;

    private void Start()
    {
        m_scoreManager = ScoreManager.Instance;
        m_gameManager = GameManager.Instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        m_scoreManager.AddScore();
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log($"Game Manager is null? {m_gameManager==null}");
        m_gameManager.GameOver();
    }
}
