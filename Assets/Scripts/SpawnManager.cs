using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject m_pipes;
    [SerializeField] private float m_SpawnDelay;
    
    // TODO change hard coded screen boundary to use Screen.width/height?
    //getting from game manager now - private float m_screenboundary = 14f;
    private float m_minpipeSpawnHeight = -3.5f;
    private float m_maxpipeSpawnHeight = 3.5f;

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
        float pipeSpawnHeight = GetRandomPipeHeight();
        Vector3 spawnPosition = new Vector3(GameManager.screenBoundaryX, pipeSpawnHeight, 0);

        Instantiate(m_pipes, spawnPosition, Quaternion.identity);
    }

    private float GetRandomPipeHeight()
    {
        return Random.Range(m_minpipeSpawnHeight, m_maxpipeSpawnHeight);
    }
}
