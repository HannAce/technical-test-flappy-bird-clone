using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int m_score;
    // Replaced this with event, leaving for thought process
    //[SerializeField] private ScoreUI m_scoreUI;
    //[SerializeField] private ScoreUI m_finalScoreUI;
    
    public Action<int> OnScoreChanged;

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
        OnScoreChanged?.Invoke(m_score);
        // Replaced this with event, leaving for thought process
        //m_scoreUI.UpdateScoreUI(m_score);
        //m_finalScoreUI.UpdateScoreUI(m_score);
        Debug.Log($"[ScoreManager] Score: {m_score}");
    }
}
