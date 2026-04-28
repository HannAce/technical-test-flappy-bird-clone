using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int m_score;
    
    public static ScoreManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void OnDestroy()
    {
        Instance = null;
    }

    public void AddScore()
    {
        m_score++;
        Debug.Log($"[ScoreManager] Score: {m_score}");
    }
}
