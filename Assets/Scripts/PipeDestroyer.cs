using System;
using UnityEngine;

public class PipeDestroyer : MonoBehaviour
{
    // Added in game manager to avoid repeated variable
   //private float m_screenBoundaryX = 14f;

    private void Update()
    {
        if (transform.position.x < -GameManager.ScreenBoundaryX)
        {
            DestroyPipe();
        }
    }

    private void DestroyPipe()
    {
       Destroy(gameObject); 
    }
}
