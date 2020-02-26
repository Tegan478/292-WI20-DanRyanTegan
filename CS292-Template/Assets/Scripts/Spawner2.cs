using System.Collections;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] items;
    public GameObject bomb;

    private int count = 0;
    private int wCount = 0;
    private int inWave = 0;
    public static int numItems = 0;

    private int spawnTime = 120;
    private int waveTime = 120;
    private int perWave = 0;

    private int[] firstTimes = { 120, 120, 120, 60, 0, 120, 60, 60, 60, 0, 0, 120, 90, 0, 0, 0, 120 };
    private static int[] spawnTimes = { 0, 30, 30, 30, 30, 60, 90 };
    private int[] randomTimes = { 0, 0, 0, 0, 15, 30, 60 };
    private int[] perWaveChance = { 1, 2, 3, 4, 4, 5, 5, 5, 6, 6 };

    private int[] waveTimes = { 0, 60, 60, 60, 90, 90 };

    private ArrayList spawnTimesList = new ArrayList(spawnTimes);



    private void Start()
    {
        numItems = 0;
    }

    void FixedUpdate()
    {

        if (numItems % 10 == 0)
        {
            print("numItems is divisible by 10");
            numItems++;
            spawnTimesList.Add(randomTimes[Random.Range(0, randomTimes.Length)]);
        }
        count++;
        if (count >= spawnTime)
        {
            Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            GameObject randomItem = items[Random.Range(0, items.Length)];

            //testingbomb
            //Instantiate(bomb, new Vector3(randomSpawnPoint.position.x, randomSpawnPoint.position.y, 0), randomSpawnPoint.rotation);


            Instantiate(randomItem, new Vector3(randomSpawnPoint.position.x, randomSpawnPoint.position.y, 0), randomSpawnPoint.rotation);
            numItems++;
            inWave++;
            print(numItems);
            if (numItems <= firstTimes.Length)
            {
                spawnTime = firstTimes[numItems - 1];

            }
            else
            {
                spawnTime = (int)spawnTimesList[Random.Range(0, spawnTimesList.Count)];
            }

            count = 0;
        }
    }


}

//code from Udemy "Make your first 2D game with Unity and C# - Beginner Course"
