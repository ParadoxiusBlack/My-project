using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawnerManager : MonoBehaviour
{
    public GameObject[] powerUpPrefabs; // Array to store power ups
    private float spawnRangeX = 30f;
    private float spawnPosZ = 40f;

    private float startDelay = 5f;
    private float spawnInterval = 5.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomPowerUp", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomPowerUp()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),3f,spawnPosZ); 
        int powerIndex = Random.Range(0,powerUpPrefabs.Length); //Picks a random powerup from the array
        Instantiate(powerUpPrefabs[powerIndex],spawnPos, powerUpPrefabs[powerIndex].transform.rotation); //Spawns indexed powerup from the array at a random location on the x axis
    }
}
