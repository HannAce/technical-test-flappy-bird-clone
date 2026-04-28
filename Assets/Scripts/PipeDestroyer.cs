using System;
using UnityEngine;

public class PipeDestroyer : MonoBehaviour
{
    // TODO create one screenboundary in GameManager when created and get from there? Avoids repeated variable
    //private float m_screenBoundaryX = 14f;

    private void Update()
    {
        if (transform.position.x < -GameManager.screenBoundaryX)
        {
            DestroyPipe();
        }
    }

    private void DestroyPipe()
    {
       Destroy(gameObject); 
    }
}
