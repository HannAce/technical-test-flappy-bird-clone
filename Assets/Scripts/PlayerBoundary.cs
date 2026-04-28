using UnityEngine;

public class PlayerBoundary : MonoBehaviour
{
    private GameManager m_gameManager;

    private void Start()
    {
        m_gameManager = GameManager.Instance;
    }

    private void Update()
    {
        CheckPlayerOutOfBounds();
    }

    private void CheckPlayerOutOfBounds()
    {
        float screenBoundary = m_gameManager.GetScreenBoundary().y;
        float playerHeight = transform.position.y;

        if (playerHeight > screenBoundary + GameManager.ScreenBoundaryPadding ||
            playerHeight < -screenBoundary - GameManager.ScreenBoundaryPadding)
        {
            m_gameManager.GameOver();
        }
    }
}
