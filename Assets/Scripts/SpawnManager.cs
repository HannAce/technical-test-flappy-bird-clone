using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject m_pipes;
    [SerializeField] private float m_SpawnDelay;
    
    // Added in game manager to avoid repeated variable
    // private float m_screenboundary = 14f;
    private GameManager m_gameManager;
    
    private float m_minpipeSpawnHeight;
    private float m_maxpipeSpawnHeight;
    private const float m_pipeSpawnPositionOffset = 0.4f;

    private void Start()
    {
        m_gameManager = GameManager.Instance;
        
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
        Vector3 spawnPosition = GetRandomPipePosition();
        Instantiate(m_pipes, spawnPosition, Quaternion.identity);
    }

    private Vector3 GetRandomPipePosition()
    {
        m_minpipeSpawnHeight = -m_gameManager.GetScreenBoundary().y * m_pipeSpawnPositionOffset;
        m_maxpipeSpawnHeight = m_gameManager.GetScreenBoundary().y * m_pipeSpawnPositionOffset;
        
        float randomPipeHeight = Random.Range(m_minpipeSpawnHeight, m_maxpipeSpawnHeight);

        return new Vector3(m_gameManager.GetScreenBoundary().x + GameManager.ScreenBoundaryPadding, randomPipeHeight, 0);
    }
}
