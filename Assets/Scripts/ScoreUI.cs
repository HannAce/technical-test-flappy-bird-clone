using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TMP_Text m_scoreText;
    [SerializeField] private bool m_isFinalScore;

    private ScoreManager m_scoreManager;

    private void Start()
    {
        m_scoreManager = ScoreManager.Instance;
        m_scoreManager.OnScoreChanged += UpdateScoreUI;

        UpdateScoreUI(0);
    }

    private void OnDestroy()
    {
        if (m_scoreManager != null)
        {
            m_scoreManager.OnScoreChanged -= UpdateScoreUI;
        }
    }

    private void UpdateScoreUI(int score)
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
