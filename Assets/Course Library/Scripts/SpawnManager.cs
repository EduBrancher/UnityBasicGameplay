using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour {

    [SerializeField] float spawnRatePerSecond; //chance an animal spawns per second between 0..1
    [SerializeField] float xBoundSpawn; //x limits on spawning area
    [SerializeField] float zBoundSpawnMax; //z max limit on spawning area
    [SerializeField] float zBoundSpawnMin; //z min limit on spawning area
    [SerializeField] List<GameObject> animalPrefabs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Random.InitState(DateTime.UtcNow.Millisecond);
    }

    // Update is called once per frame
    void Update() {
        float animalSpawn = Random.Range(0f, 1f);
        if (animalSpawn < spawnRatePerSecond * Time.deltaTime) {
            SpawnAnimal();
        }
    }

    void SpawnAnimal() {
        var xSpawn = Random.Range(-xBoundSpawn, xBoundSpawn);
        var zSpawn = Random.Range(zBoundSpawnMin, zBoundSpawnMax);
        //spawn an animal charging down the screen
        var index = Random.Range(0, animalPrefabs.Count);
        Instantiate(animalPrefabs[index], new Vector3(xSpawn, 0, zSpawn), animalPrefabs[index].transform.rotation);
    }
}
