using System;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TMP_Text m_scoreText;

    private void Start()
    {
        UpdateScoreUI(0);
    }

    public void UpdateScoreUI(int score)
    {
        m_scoreText.text = $"Score: {score}";
    }
}
