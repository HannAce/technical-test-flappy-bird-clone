using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource m_audioSource;
    [SerializeField] private AudioClip m_flapSFX;
    [SerializeField] private AudioClip m_scoreSFX;
    [SerializeField] private AudioClip m_gameOverSFX;

    private ScoreManager m_scoreManager;
    private GameManager m_gameManager;

    private void Start()
    {
        PlayerInput.OnPlayerFlapped += PlayFlapSFX;
        
        m_scoreManager = ScoreManager.Instance;
        m_scoreManager.OnScoreChanged += PlayScoreSFX;
        
        m_gameManager = GameManager.Instance;
        m_gameManager.OnGameOver += PlayGameOverSFX;
    }

    private void OnDestroy()
    {
        PlayerInput.OnPlayerFlapped -= PlayFlapSFX;
        
        if (m_scoreManager != null) 
        {
            m_scoreManager.OnScoreChanged -= PlayScoreSFX;
        }

        if (m_gameManager != null)
        {
            m_gameManager.OnGameOver -= PlayGameOverSFX;
        }
    }

    private void PlaySFX(AudioClip audioClip, float volume)
    {
        m_audioSource.PlayOneShot(audioClip, volume);
    }


    private void PlayFlapSFX()
    {
        PlaySFX(m_flapSFX, 0.7f);
    }

    // Needed int parameter to be compatible with the event, is it okay if not used?
    private void PlayScoreSFX(int score)
    {
        PlaySFX(m_scoreSFX, 0.7f);
    }
    
    private void PlayGameOverSFX()
    {
        PlaySFX(m_gameOverSFX, 0.8f);
    }
}
