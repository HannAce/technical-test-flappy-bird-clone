using System;
using UnityEngine;

public class PlayerCollisionDetector : MonoBehaviour
{
    private ScoreManager m_scoreManager;

    private void Start()
    {
        m_scoreManager = ScoreManager.Instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        m_scoreManager.AddScore();
    }
}
