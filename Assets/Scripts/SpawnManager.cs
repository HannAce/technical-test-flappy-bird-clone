using System;
using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject m_pipes;

    [SerializeField] private float m_SpawnDelay;
    
    // TODO change hard coded screen boundary to use Screen.width?
    private float m_screenboundary = 14f;
    

    private void Start()
    {
        StartCoroutine(SpawnPipeRoutine());
    }

    IEnumerator SpawnPipeRoutine()
    {
        SpawnPipe();
        yield return new WaitForSeconds(m_SpawnDelay);
        StartCoroutine(SpawnPipeRoutine());
    }

    private void SpawnPipe()
    {
        Vector3 spawnPosition = new Vector3(m_screenboundary, 0, 0);

        Instantiate(m_pipes, spawnPosition, Quaternion.identity);
    }
    
}
