using System;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TMP_Text m_scoreText;
    [SerializeField] private bool m_isFinalScore;

    private void Start()
    {
        UpdateScoreUI(0);
    }

    public void UpdateScoreUI(int score)
    {
        if (m_isFinalScore)
        {
            m_scoreText.text = $"Final Score: {score}"; 
        }
        else
        {
            m_scoreText.text = $"Score: {score}";
        }
    }
}
