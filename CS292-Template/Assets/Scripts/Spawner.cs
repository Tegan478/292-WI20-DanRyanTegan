using System.Collections;
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

            Instantiate(randomItem, randomSpawnPoint.position, Quaternion.identity);

            Rigidbody2D rigidFood = Instantiate(randomItem.GetComponent<Rigidbody2D>());
            rigidFood.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
            rigidFood.transform.localScale = new Vector2(1.0f, 1.0f);
            rigidFood.AddForce(rigidFood.transform.forward * 30.0f);
            rigidFood.velocity = Vector3.up * 70;

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
