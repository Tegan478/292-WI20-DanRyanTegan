﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] items;
    public GameObject[] bomb;

    private float timeBtwSpawns;
    public float startTimeBtwSpawns;

    public float minTimeBtwSpawns;
    public float decrease;

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
    }
}

//code from Udemy "Make your first 2D game with Unity and C# - Beginner Course"
