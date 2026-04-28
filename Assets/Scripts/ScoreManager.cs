using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int m_score;
    [SerializeField] private ScoreUI m_scoreUI;
    [SerializeField] private ScoreUI m_finalScoreUI;
    
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
        // TODO try to make an event for updating score which ScoreUI can subscribe to?
        m_scoreUI.UpdateScoreUI(m_score);
        m_finalScoreUI.UpdateScoreUI(m_score);
        Debug.Log($"[ScoreManager] Score: {m_score}");
    }
}
