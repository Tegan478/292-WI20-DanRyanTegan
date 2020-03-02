using System.Collections;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] items;
    public GameObject bomb;

    private int count = 0;

    public static int numItems = 0;

    private int spawnTime = 120;

    private int[] firstTimes = { 120, 120, 120, 60, 0, 120, 60, 60, 60, 0, 0, 120, 90, 0, 0, 0, 120 };
    private static int[] spawnTimes = { 0, 30, 30, 30, 30, 60, 90 };
    private int[] randomTimes = { 0, 0, 15, 30 };

    private ArrayList spawnTimesList = new ArrayList(spawnTimes);

    float bombfreq = 340f;
    float track = 340f;
    float minusby = 1f;

    private void Start()
    {
        numItems = 0;
    }

    void FixedUpdate()
    {

        if (numItems % 10 == 0)
        {
            //print("numItems is divisible by 10");
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
            print(numItems);
            if (numItems <= firstTimes.Length+1)
            {
                spawnTime = firstTimes[numItems - 2];

            }
            else
            {
                if (numItems % 7 == 0)
                {
                    //print("div by 7");
                    spawnTime = 120;
                }
                else
                    spawnTime = (int)spawnTimesList[Random.Range(0, spawnTimesList.Count)];
            }

            count = 0;
        }

        if (track <= 0)
        {
            Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(bomb, new Vector3(randomSpawnPoint.position.x, randomSpawnPoint.position.y, 0), randomSpawnPoint.rotation);
            track = bombfreq;
        } else
        {
            track -= minusby;
        }

        if (Blade.count < 10)
        {
            bombfreq = 300f;
            minusby = 1f;
        } else if (Blade.count < 20)
        {
            bombfreq = 270f;
        } else if (Blade.count < 30)
        {
            bombfreq = 220f;
        }
        else if (Blade.count < 40)
        {
            bombfreq = 170f;

        }
        else if (Blade.count < 50)
        {
            bombfreq = 140f;
        }
        else
        {
            bombfreq = 130f;
        }
    }


}

//code from Udemy "Make your first 2D game with Unity and C# - Beginner Course"
