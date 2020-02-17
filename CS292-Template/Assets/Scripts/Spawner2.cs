using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] items;
    public GameObject bomb;

    private int count;
    private int spawnTime = 30;



    void FixedUpdate()
    {
        count++;
        if (count >= spawnTime) {
            Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            GameObject randomItem = items[Random.Range(0, items.Length)];

            Instantiate(randomItem, new Vector3(randomSpawnPoint.position.x, randomSpawnPoint.position.y, 0), randomSpawnPoint.rotation);
            spawnTime = Random.Range(5, 80);
            count = 0;
        }
    }
}

//code from Udemy "Make your first 2D game with Unity and C# - Beginner Course"
