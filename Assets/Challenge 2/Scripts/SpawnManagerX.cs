using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    public float minTimeBetweenSpawns = 3f;
    public float maxTimeBetweenSpawns = 5f;
    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;
    private float spawnTimer = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update() {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0) {
            SpawnRandomBall();
            spawnTimer = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        // instantiate ball at random spawn location
        var index = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);
    }

}
