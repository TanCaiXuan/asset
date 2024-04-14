using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnObstacles : MonoBehaviour
{
    public GameObject[] GoodActionsPrefabs;
    public GameObject[] BadActionsPrefabs;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;
    bool canSpawn = true;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Vector3 spawnPosition = transform.position + new Vector3(randomX, randomY, 0);

        // Check if there's any obstacle at the spawn position
        Collider2D hit = Physics2D.OverlapCircle(spawnPosition, 0.1f);

        if (canSpawn)
        {
            // If there's no obstacle, spawn both good and bad prefabs
            if (hit == null)
            {
                // Randomly choose between GoodActionsPrefab and BadActionsPrefab
                GameObject prefabToSpawn = Random.Range(0f, 1f) < 0.5f ? GoodActionsPrefabs[Random.Range(0, GoodActionsPrefabs.Length)] : BadActionsPrefabs[Random.Range(0, BadActionsPrefabs.Length)];

                Instantiate(prefabToSpawn, spawnPosition, transform.rotation);

            }
            else
            {
                // Adjust spawn position if there's already an obstacle
                Spawn();
            }
        }
        

        //float randomX = Random.Range(minX, maxX);
        //float randomY = Random.Range(minY, maxY);

        //Instantiate(GoodActionsPrefabs[Random.Range(0, GoodActionsPrefabs.Length)], transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        //Instantiate(BadActionsPrefabs[Random.Range(0, BadActionsPrefabs.Length)], transform.position + new Vector3(randomX, randomY, 0), transform.rotation);

    }

    public void DisableSpawnObject()
    {
        canSpawn = false;
    }
}




