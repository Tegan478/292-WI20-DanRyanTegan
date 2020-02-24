using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] items;
    public GameObject bomb;

    private float timeBtwSpawns = 2f;
    public static float startTimeBtwSpawns;
    public float minTimeBtwSpawns;
    public float decrease;

    private float bombTimeMin = 4f;
    private float bombTimeStart = 5;
    private float newBomb = 10f;
    private float decBomb = .5f;



    void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            GameObject randomItem = items[Random.Range(0, items.Length)];

            Instantiate(randomItem, new Vector3(randomSpawnPoint.position.x, randomSpawnPoint.position.y, 0), randomSpawnPoint.rotation);

            if (startTimeBtwSpawns > minTimeBtwSpawns)
            {
                startTimeBtwSpawns -= decrease;
            }

            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }

        if (newBomb <= 0)
        {
            Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            Instantiate(bomb, new Vector3(randomSpawnPoint.position.x, randomSpawnPoint.position.y, 0), randomSpawnPoint.rotation);

            if (bombTimeStart > bombTimeMin)
            {
                bombTimeStart -= decBomb;
            }

            newBomb = bombTimeStart;

        }
        else
        {
            newBomb -= Time.deltaTime;
        }
    }
}

//code from Udemy "Make your first 2D game with Unity and C# - Beginner Course"
